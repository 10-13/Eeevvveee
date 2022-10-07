using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User32Interface
{
    public static class WindowHandling
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public static Rectangle GetWindowBounds(IntPtr Handle)
        {
            RECT rect = new RECT();
            GetWindowRect(Handle,out rect);
            return new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
        }
        public static bool SetAsForegroundWindow(IntPtr Handle)
        {
            if(GetForegroundWindow() != Handle)
                return SetForegroundWindow(Handle);
            return false; 
        }
    }
}
