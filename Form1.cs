using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AutoTune
{
    public partial class Form1 : Form
    {
        const string FAIL = "failed";
        const string SUCCESS = "success";

        Extraction extraction = new Extraction();
        MouseEvent mouse = new MouseEvent();
        Hashtable inventory = new Hashtable();

        string text = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            lb_Item1.Text = "ㅋㅋㅋ";

            for (int i = 0; i < 8; i++)
            {
                Item item = (Item)inventory[i];

                while (item == null)
                {
                    inventory.Add(i, new Item());
                    item = (Item)inventory[i];

                    mouse.BillBoardClick();
                    mouse.BuyBtnClick();
                    mouse.BuyItemClick();
                    mouse.OkBtnClick();

                    mouse.TuneBtnClick();                   
                    Debug.WriteLine("아이템 : " + i.ToString() + ", 레벨 : " + item.Level.ToString() + ", 내구도 : " + item.Durability.ToString());                    

                    while (item.Level != 7 && item.Durability != 1)
                    {
                        mouse.ItemClick(MouseEvent.itemsPoint[i]);
                        mouse.TuningClick();

                        text = GetTextAndBind();

                        if (text.Contains(SUCCESS))
                        {
                            item.SucceedTune();
                        }
                        else if (text.Contains(FAIL))
                        {
                            item.DownDurability();
                        }
                        
                        Debug.WriteLine("아이템 : " + i.ToString() + ", 레벨 : " + item.Level.ToString() + ", 내구도 : " + item.Durability.ToString());                        
                    }

                    if (item.Level != 7 && item.Durability == 1)
                    {
                        inventory.Remove(i);
                        item = null;

                        mouse.BillBoardClick();
                        mouse.SellBtnClick();
                        mouse.ItemClick(MouseEvent.itemsPoint[i]);
                    }
                }
            }
        }

        

        private string GetTextAndBind()
        {                         
            Page page = extraction.Render(ImageMapper);
            String text = page.GetText();

            return text;
        }
        
        
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }

   
}
