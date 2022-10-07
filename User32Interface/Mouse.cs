

using System.Runtime.InteropServices;

namespace User32Interface
{
    class MouseAccess
    {
        public enum MouseEvents
        {
            MOUSEEVENTF_ABSOLUTE = 0x8000,
            MOUSEEVENTF_LEFTDOWN = 0x0002,
            MOUSEEVENTF_LEFTUP = 0x0004,
            MOUSEEVENTF_MIDDLEDOWN = 0x0020,
            MOUSEEVENTF_MIDDLEUP = 0x0040,
            MOUSEEVENTF_MOVE = 0x0001,
            MOUSEEVENTF_RIGHTDOWN = 0x0008,
            MOUSEEVENTF_RIGHTUP = 0x0010,
            MOUSEEVENTF_XDOWN = 0x0080,
            MOUSEEVENTF_XUP = 0x0100,
            MOUSEEVENTF_WHEEL = 0x0800,
            MOUSEEVENTF_HWHEEL = 0x01000
        }

        private const int BasicDelay = 350;

        /// <summary>
        /// Generates mouse event
        /// </summary>
        /// <param name="dwFlags">Event type</param>
        /// <param name="dx">Position X</param>
        /// <param name="dy">Position Y</param>
        /// <param name="dwData">Always 0</param>
        /// <param name="dwExtraInfo">Always new IntPtr()</param>
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);

        public static void MouseClick(int x,int y)
        {
            IntPtr f = new IntPtr();
            mouse_event((uint)MouseEvents.MOUSEEVENTF_LEFTDOWN, (uint)x, (uint)y, 0, f);
            Thread.Sleep(UserEmu.GetDelay(UserEmu.DelayMode.Click, false, false, 0));
            mouse_event((uint)MouseEvents.MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, f);
        }
    }

}