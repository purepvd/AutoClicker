using System.Runtime.InteropServices;

namespace AutoClickerNetCore;

public class SendInputClickStrategy
{
    [StructLayout(LayoutKind.Sequential)]
    struct INPUT
    {
        public uint type;
        public MOUSEINPUT mi;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct MOUSEINPUT
    {
        public int dx;
        public int dy;
        public uint mouseData;
        public uint dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    private const uint INPUT_MOUSE = 0;
    private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
    private const uint MOUSEEVENTF_LEFTUP = 0x0004;

    [DllImport("user32.dll", SetLastError = true)]
    private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

    public static async Task ClickAt(int x, int y)
    {
        Cursor.Position = new System.Drawing.Point(x, y);

        INPUT[] inputs = new INPUT[2];

        // Mouse Left Button Down
        inputs[0].type = INPUT_MOUSE;
        inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

        if (Form1.DownUpClickPause > 0)
        {
            await Task.Delay(Form1.DownUpClickPause);
        }
        
        // Mouse Left Button Up
        inputs[1].type = INPUT_MOUSE;
        inputs[1].mi.dwFlags = MOUSEEVENTF_LEFTUP;

        SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
    }
    
    public static void ClickDownAt(int x, int y)
    {
        Cursor.Position = new System.Drawing.Point(x, y);

        INPUT[] inputs = new INPUT[2];

        // Mouse Left Button Down
        inputs[0].type = INPUT_MOUSE;
        inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

        SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
    }
    
    public static void ClickUpAt(int x, int y)
    {
        Cursor.Position = new System.Drawing.Point(x, y);

        INPUT[] inputs = new INPUT[2];

        // Mouse Left Button Down
        inputs[0].type = INPUT_MOUSE;
        inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTUP;

        SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
    }
}