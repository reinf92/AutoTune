using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tesseract;
using System.Threading;
using System.Windows.Forms;

namespace AutoTune
{
    class MouseEvent
    {
        public static Point[] itemsPoint =
        {
            new Point(5020, 780),
            new Point(5190, 780),
            new Point(5020, 860),
            new Point(5190, 860),
            new Point(5020, 950),
            new Point(5190, 950),
            new Point(5020, 1040),
            new Point(5190, 1040)
        };        

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;

        public void BuyBtnClick()
        {
            Cursor.Position = new Point(3550, 290);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
        }

        public void BuyItemClick()
        {
            Cursor.Position = new Point(3800, 570);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
        }

        public void OkBtnClick()
        {
            Cursor.Position = new Point(4370, 500);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(500);
        }

        public void SellBtnClick()
        {
            Cursor.Position = new Point(3700, 290);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
        }

        public void TuneBtnClick()
        {
            Cursor.Position = new Point(3838, 290);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);            
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
        }

        public void TuningClick()
        {
            Cursor.Position = new Point(4170, 730);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(5000);
        }

        public void ItemClick(Point point)
        {
            Cursor.Position = point;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
        }

        public void BillBoardClick()
        {
            Cursor.Position = new Point(3950, 140);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(200);
        }
    }
}
