using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickerNetCore
{
    internal static class GlobalHotKey
    {
        // Import user32.dll functions
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Modifier keys
        private const uint MOD_ALT = 0x0001;
        private const uint MOD_CONTROL = 0x0002;
        private const uint MOD_SHIFT = 0x0004;
        private const uint MOD_WIN = 0x0008;

        // Windows message identifier for hotkey
        internal const int WM_HOTKEY = 0x0312;

        public static void RegisterGlobalHotKey(IntPtr handle)
        {
            // Register Ctrl + Shift + T as a global hotkey
            RegisterHotKey(handle, 1, MOD_CONTROL | MOD_SHIFT, (uint)Keys.T);
        }

        public static void UnegisterGlobalHotKey(IntPtr handle)
        {
            UnregisterHotKey(handle, 1);
        }
    }
}
