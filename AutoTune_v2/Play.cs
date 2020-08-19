using System;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.IO;
using Tesseract;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Controls;

namespace AutoTune_v2
{
  
    class Play
    {
        MainWindow window;
        Thread back;        
        Click cEvent;
        Dictionary<int, Item> itemList;

        List<Label> items = new List<Label>();
        List<Label> faileds = new List<Label>();

        int handle;
        const string FIX_TEXT = "suc";
        
        public Play(MainWindow mainWindow)
        {
            string windowName = "MAKE ITEMS";
            string windowNameEx = "BlueStacks Android PluginAndroid_1";

            window = mainWindow;
            handle = Win32.FindWindowEx(Win32.FindWindow(null, windowName), 0, null, windowNameEx);
            cEvent = new Click(handle);
            itemList = new Dictionary<int, Item>();

            MappingView();
        }

        public void MappingView()
        {
            items.Add(window.Item_1);
            items.Add(window.Item_2);
            items.Add(window.Item_3);
            items.Add(window.Item_4);
            items.Add(window.Item_5);
            items.Add(window.Item_6);
            items.Add(window.Item_7);
            items.Add(window.Item_8);

            faileds.Add(window.Failed_1);
            faileds.Add(window.Failed_2);
            faileds.Add(window.Failed_3);
            faileds.Add(window.Failed_4);
            faileds.Add(window.Failed_5);
            faileds.Add(window.Failed_6);
        }

        public void Run()
        {
            back = new Thread(new ThreadStart(Macro));
            back.Start();                    
        }
        
        public void Macro()
        {
            int count = 0;
            int level = 0;

            window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (ThreadStart)delegate ()
            {
                itemList.Clear();

                count = int.Parse(window.ItemCount.Text);
                level = int.Parse(window.ItemLevel.Text);
            });

            Thread.Sleep(500);

            for (int i = 0; i < count; i++)
            {
                Item item = null;

                while (!itemList.TryGetValue(i, out item))
                {
                    UpdateCurrentMessage("To buy and sell..");

                    itemList[i] = new Item();

                    cEvent.Board();
                    cEvent.Buy();
                    cEvent.Tune();

                    UpdateLabelMessage(items[i], itemList[i], "ITEM");

                    while (itemList[i].Level < level && itemList[i].Durability > 1)
                    {
                        UpdateCurrentMessage("Tuning...");

                        cEvent.Tune(i);

                        bool result = false;

                        window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (ThreadStart)delegate ()
                        {
                            result = Enhance();
                        });

                        Thread.Sleep(500);

                        if (result)
                        {
                            UpdateCurrentMessage("Success!!");
                            itemList[i].TuneSuccess();
                        }
                        else
                        {
                            UpdateCurrentMessage("Failed..");
                            itemList[i].TuneFailed();
                                 
                        }

                        UpdateLabelMessage(items[i], itemList[i], "ITEM");
                    }

                    if (itemList[i].Durability == 1)
                    {
                        UpdateLabelMessage(faileds[itemList[i].Level-1], itemList[i], "FAIL");
                        UpdateCurrentMessage("To buy and sell..");

                        itemList.Remove(i);
                        cEvent.Board();
                        cEvent.Sell(i);
                    }
                }
            }
        }
        private void Clear()
        {
            itemList.Clear();

            window.Item_1.Content = "0(100)";
            window.Item_2.Content = "0(100)";
            window.Item_3.Content = "0(100)";
            window.Item_4.Content = "0(100)";
            window.Item_5.Content = "0(100)";
            window.Item_6.Content = "0(100)";
            window.Item_7.Content = "0(100)";
            window.Item_8.Content = "0(100)";

            window.Failed_1.Content = "v1 Failed : 0";
            window.Failed_2.Content = "v2 Failed : 0";
            window.Failed_3.Content = "v3 Failed : 0";
            window.Failed_4.Content = "v4 Failed : 0";
            window.Failed_5.Content = "v5 Failed : 0";
            window.Failed_6.Content = "v6 Failed : 0";
        }

        public void UpdateCurrentMessage(string message)
        {
            window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (ThreadStart)delegate ()
            {
                window.Progress.Content = "Current Progress : " + message;
            });

            Thread.Sleep(100);
        }

        public void UpdateLabelMessage(Label label, Item item, string type)
        {
            window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (ThreadStart)delegate ()
            {
                if (type.Equals("ITEM"))
                {
                    label.Content = item.Level + "(" + item.Durability + ")";
                }

                if (type.Equals("FAIL"))
                {
                    string content = (string)label.Content;
                    string fix = content.Substring(0, 12);
                    string number = content.Substring(12, content.Length - 12);

                    label.Content = fix + (int.Parse(number) + 1);
                }
            });

            Thread.Sleep(100);
        }

        public bool Enhance()
        {
            Bitmap bitmap = Win32.PrintWindow();
            string text = ExtractText(bitmap);
            BindImage(bitmap);

            return text.Contains(FIX_TEXT);
        }

        private void BindImage(Bitmap bitmap)
        {
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

            var bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.CacheOption = BitmapCacheOption.OnLoad;
            bi.EndInit();
            
            window.Screen.Source = bi;                
        }

        private string ExtractText(Bitmap bitmap)
        {
            TesseractEngine engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
            Tesseract.Page page = engine.Process(bitmap);

            return page.GetText();
        }

        private IntPtr ConvertLParam(int LoWord, int HiWord)
        {
            return (IntPtr)((HiWord << 16) | (LoWord & 0xffff));
        }

        public void Abort()
        {
            if (back != null)
            {
                back.Abort();
            }
        }
    }
}
