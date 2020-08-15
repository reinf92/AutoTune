using System;
using System.Threading;
using System.Drawing;
using IronOcr;
using System.Windows.Forms;

namespace AutoTune
{
    class Control
    {
        public Control(int code)
        {
            this.SystemCode = code;
        }

        private int SystemCode;

        private const int BUY_BTN_X = 110;
        private const int BUY_BTN_Y = 250;
        private const int SELL_BTN_X = 260;
        private const int SELL_BTN_Y = 250;
        private const int TUNE_BTN_X = 390;
        private const int TUNE_BTN_Y = 250;
        private const int OK_BTN_X = 930;
        private const int OK_BTN_Y = 460;
        private const int BILL_BOARD_X = 500;
        private const int BILL_BOARD_Y = 100;
        private const int SHOP_X = 360;
        private const int SHOP_Y = 530;
        private const int TUNING_X = 730;
        private const int TUNING_Y = 690;
        private const string IMAGE_EXTRACTION_TEXT_SUCCESS = "suc";

        private static int[] INVENTORY_X = { 1580, 1750, 1580, 1750, 1580, 1750, 1580, 1750 };
        private static int[] INVENTORY_Y = { 740, 740, 830, 830, 920, 920, 1010, 1010 };

        public void Ready()
        {
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(BILL_BOARD_X, BILL_BOARD_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(BILL_BOARD_X, BILL_BOARD_Y));
            Thread.Sleep(200);

            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(BILL_BOARD_X, BILL_BOARD_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(BILL_BOARD_X, BILL_BOARD_Y));
            Thread.Sleep(200);

            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(BILL_BOARD_X, BILL_BOARD_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(BILL_BOARD_X, BILL_BOARD_Y));
            Thread.Sleep(200);
        }

        public void Buy()
        {
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(BUY_BTN_X, BUY_BTN_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(BUY_BTN_X, BUY_BTN_Y));
            Thread.Sleep(200);

            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(SHOP_X, SHOP_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(SHOP_X, SHOP_Y));
            Thread.Sleep(200);

            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(OK_BTN_X, OK_BTN_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(OK_BTN_X, OK_BTN_Y));
            Thread.Sleep(200);
        }

        public void Sell(int index)
        {
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(SELL_BTN_X, SELL_BTN_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(SELL_BTN_X, SELL_BTN_Y));
            Thread.Sleep(200);

            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(INVENTORY_X[index], INVENTORY_Y[index]));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(INVENTORY_X[index], INVENTORY_Y[index]));
            Thread.Sleep(200);
        }

        public void TuneReady()
        {
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(TUNE_BTN_X, TUNE_BTN_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(TUNE_BTN_X, TUNE_BTN_Y));
            Thread.Sleep(200);
        }

        public void Tune(int index)
        {
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(INVENTORY_X[index], INVENTORY_Y[index]));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(INVENTORY_X[index], INVENTORY_Y[index]));
            Thread.Sleep(200);

            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONDOWN, 0x00000001, ConvertLParam(TUNING_X, TUNING_Y));
            Win32.SendMessage(SystemCode, Win32.WM_LBUTTONUP, 0x00000001, ConvertLParam(TUNING_X, TUNING_Y));
            Thread.Sleep(5500);
        }
        public bool ImageRender(PictureBox box)
        {            
            Bitmap bmp = Win32.PrintWindow();
            box.Image = bmp;
            var Ocr = new AutoOcr();
            var result = Ocr.Read(bmp);                 

            return result.Text.Contains(IMAGE_EXTRACTION_TEXT_SUCCESS);            
        }

        private IntPtr ConvertLParam(int LoWord, int HiWord)
        {
            return (IntPtr)((HiWord << 16) | (LoWord & 0xffff));
        }
    }    
}
