using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

using IronOcr;

namespace AutoTune
{
    public partial class Form1 : Form
    {
        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventDelMessage;

        System.Int32 BlueStack;
        System.Int32 AstroN;
        Dictionary<int, Item> list;
        Control control;
        Thread thread;

        Label[] items;
        Label[] failures;

        public void ThreadStart()
        {
            thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }
        
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BlueStack = Win32.FindWindow("HwndWrapper[BlueStacks.exe;;ea27ec53-eaea-422a-98cc-285f93753fdc]", "BlueStacks 1 ");
            AstroN = Win32.FindWindowEx(BlueStack, 0, null, "BlueStacks Android PluginAndroid_1");
            list = new Dictionary<int, Item>();
            control = new Control(AstroN);

            items = new Label[] {
                lb_Item1,
                lb_Item2,
                lb_Item3,
                lb_Item4,
                lb_Item5,
                lb_Item6,
                lb_Item7,
                lb_Item8
            };

            failures = new Label[] {
                lb_Failure1,
                lb_Failure2,
                lb_Failure3,
                lb_Failure4,
                lb_Failure5,
                lb_Failure6
            };
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
   
            Thread.Sleep(5000);
            //Run();
            ThreadStart();

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            thread.Abort();
            MessageBox.Show("종료");
        }

        private void Run()
        {
            for (int i = 0; i < ItemsCountSetting.Value; i++)
            {
                Item temp = null;

                while(!list.TryGetValue(i, out temp))
                {
                    list[i] = new Item();
                    
                    control.Ready();
                    control.Buy();
                    control.TuneReady();

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            list[i].BindText(items[i]);
                        }));
                    }

                    Debug.WriteLine(list[i].GetString());

                    while (list[i].Level < 7 && list[i].Durability > 1)
                    {
                        control.Tune(i);

                        if (this.InvokeRequired)
                        {
                            this.Invoke(new Action(delegate ()
                            {
                                if (control.ImageRender(iMapper))
                                {
                                    list[i].TuneSuccess();
                                }
                                else
                                {
                                    list[i].TuneFailed();
                                }
                            }));
                        }                      

                        if (this.InvokeRequired)
                        {
                            this.Invoke(new Action(delegate ()
                            {
                                list[i].BindText(items[i]);
                            }));
                        }

                        Debug.WriteLine(list[i].GetString());
                    }

                    if (list[i].Durability == 1)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new Action(delegate ()
                            {
                                list[i].BindFailed(failures[list[i].Level - 1]);
                            }));
                        }

                        list.Remove(i);
                        control.Ready();
                        control.Sell(i);                                    
                    }
                }
            }

            eventDelMessage(this, "Tune Complete!!");
        }


       
    }

   
}

