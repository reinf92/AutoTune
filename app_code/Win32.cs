using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace AutoTune
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
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("User32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        public static Bitmap PrintWindow(int hwnd)
        {
            RECT rc;
            GetWindowRect(new IntPtr(hwnd), out rc);
            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            gfxBmp.CopyFromScreen(3850, 60, 0, 0, bmp.Size);
            gfxBmp.Dispose();            

            return bmp;
        }

        public static Bitmap PrintWindow()
        {
            Bitmap bmp = new Bitmap(230, 70);
            Graphics graphics = Graphics.FromImage(bmp);
            Size size = new Size(230, 70);

            graphics.CopyFromScreen(3850, 60, 0, 0, size);
            graphics.Dispose();
            
            return bmp;
        }
    }
}
