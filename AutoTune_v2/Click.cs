using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace AutoTune_v2
{
    class Click
    {
        private System.Int32 Handle;
        public Click(System.Int32 h)
        {
            Handle = h;
        }

        private Point COORD_BUY = new Point( 110, 250 );
        private Point COORD_SELL = new Point(260, 250);
        private Point COORD_TUNE = new Point(390, 250);
        private Point COORD_OK = new Point(930, 460);
        private Point COORD_BOARD = new Point(500, 100);
        private Point COORD_SHOP = new Point(360, 530);
        private Point COORD_TUNING = new Point(730, 690);

        private Point[] COORD_ITEMS =
        {
            new Point(1580, 740),
            new Point(1750, 740),
            new Point(1580, 830),
            new Point(1750, 830),
            new Point(1580, 920),
            new Point(1750, 920),
            new Point(1580, 1010),
            new Point(1750, 1010)
        };

        
        private IntPtr ParseLParam(Point Word)
        {
            return (IntPtr)((Word.Y << 16) | (Word.X & 0xffff));
        }

        public void Board()
        {
            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_BOARD));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_BOARD));
            Thread.Sleep(300);

            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_BOARD));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_BOARD));
            Thread.Sleep(300);
        }

        public void Buy()
        {
            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_BUY));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_BUY));
            Thread.Sleep(300);

            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_SHOP));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_SHOP));
            Thread.Sleep(300);

            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_OK));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_OK));
            Thread.Sleep(300);
        }

        public void Sell(int index)
        {
            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_SELL));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_SELL));
            Thread.Sleep(300);

            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_ITEMS[index]));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_ITEMS[index]));
            Thread.Sleep(300);
        }

        public void Tune()
        {
            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_TUNE));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_TUNE));
            Thread.Sleep(300);
        }

        public void Tune(int index)
        {
            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_ITEMS[index]));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_ITEMS[index]));
            Thread.Sleep(300);

            Win32.SendMessage(Handle, Win32.WM_LBUTTONDOWN, 1, ParseLParam(COORD_TUNING));
            Win32.SendMessage(Handle, Win32.WM_LBUTTONUP, 0, ParseLParam(COORD_TUNING));
            Thread.Sleep(4500);
        }
    }
}
