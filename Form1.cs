using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;
using System.Threading;
using System.Diagnostics;

namespace AutoTune
{
    public partial class Form1 : Form
    {
        private System.Int32 BlueStack;
        private System.Int32 AstroN;
        private Dictionary<int, Item> list;
        private Control control;


        string text = string.Empty;
        
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BlueStack = Win32.FindWindow("HwndWrapper[BlueStacks.exe;;7b0eeda4-756d-432f-b244-1b9e8e286751]", "BlueStacks 1 ");
            AstroN = Win32.FindWindowEx(BlueStack, 0, null, "BlueStacks Android PluginAndroid_1");
            list = new Dictionary<int, Item>();
            control = new Control(AstroN);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);

            Run();
        }


        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Run()
        {
            for (int i = 0; i < 8; i++)
            {
                Item temp = null;

                while(!list.TryGetValue(i, out temp))
                {
                    list[i] = new Item();

                    control.Ready();
                    control.Buy();
                    control.TuneReady();

                    Debug.WriteLine(list[i].GetString());

                    while (list[i].Level < 7 && list[i].Durability > 1)
                    {
                        control.Tune(i);

                        if (control.ImageRender())
                        {
                            list[i].TuneSuccess();                            
                        }
                        else
                        {
                            list[i].TuneFailed();
                        }

                        Debug.WriteLine(list[i].GetString());
                    }

                    if (list[i].Durability == 1)
                    {                        
                        list.Remove(i);

                        control.Ready();
                        control.Sell(i);
                    }
                }
            }
        }


       
    }

   
}
