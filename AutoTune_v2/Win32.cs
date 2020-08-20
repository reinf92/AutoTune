using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace AutoTune_v2
{
    class Win32
    {
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;
        public const int WM_COMMAND = 0x111;
        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_LBUTTONDBLCLK = 0x203;
        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_RBUTTONUP = 0x205;
        public const int WM_RBUTTONDBLCLK = 0x206;

        [DllImport("User32.dll")]
        public static extern int FindWindow(string strClassName, string strWindowName);

        [DllImport("User32.dll")]
        public static extern int FindWindowEx(
            int hwndParent,
            int hwndChildAfter,
            string strClassName,
            string strWindowName);

        [DllImport("User32.dll")]
        public static extern Int32 SendMessage(
            int hWnd,
            int Msg,
            int wParam,
            [MarshalAs(UnmanagedType.LPStr)] string lParam);

        [DllImport("User32.dll")]
        public static extern Int32 SendMessage(
            int hWnd,
            int Msg,
            int wParam,
            IntPtr lParam);

        [DllImport("User32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);
        

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowRgn(IntPtr hWnd, IntPtr hRgn);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);


        public static Bitmap PrintWindow(int hwnd)
        { 
            Rectangle rc = Rectangle.Empty;
            Graphics gfxWin = Graphics.FromHwnd(new IntPtr(hwnd));
            rc = Rectangle.Round(gfxWin.VisibleClipBounds);
            
            Bitmap bmp = new Bitmap(
                603,
                210,
                PixelFormat.Format32bppArgb);            

            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            bool succeeded = PrintWindow(new IntPtr(hwnd), hdcBitmap, 2);
            gfxBmp.ReleaseHdc(hdcBitmap);

            if (!succeeded)
            {
                gfxBmp.FillRectangle(
                    new SolidBrush(Color.Gray),
                    new Rectangle(System.Drawing.Point.Empty, bmp.Size));
            }
            
            IntPtr hRgn = CreateRectRgn(0, 0, 0, 0);
            GetWindowRgn(new IntPtr(hwnd), hRgn);
            Region region = Region.FromHrgn(hRgn);

            if (!region.IsEmpty(gfxBmp))
            {
                gfxBmp.ExcludeClip(region);
                gfxBmp.Clear(Color.Transparent);
            }

            gfxBmp.Dispose();

            return bmp;
        }

        public static Bitmap PrintWindow()
        {
            Bitmap bmp = new Bitmap(230, 80);
            Graphics graphics = Graphics.FromImage(bmp);
            Size size = new Size(230, 80);
            graphics.CopyFromScreen(3730, 60, 0, 0, size);            
            graphics.Dispose();

            return bmp;
        }
    }
}
