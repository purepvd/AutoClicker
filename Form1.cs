using System.Runtime.InteropServices;

namespace AutoClickerNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this, checkBoxDarkMode.Checked);
            GlobalHotKey.RegisterGlobalHotKey(Handle);
        }

        // Import mouse_event from user32.dll
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        private static bool HALT_CLICKIES = false;
        internal static int DownUpClickPause = 0;

        private async void ClickAtPosition(int x, int y)
        {
            if (checkBoxAlternateClickStrategy.Checked)
            {
                await SendInputClickStrategy.ClickAt(x, y);
                return;
            }
            
            // Move the cursor
            Cursor.Position = new Point(x, y);

            // Simulate mouse click
            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)x, (uint)y, 0, UIntPtr.Zero);

            if (DownUpClickPause > 0)
            {
                await Task.Delay(DownUpClickPause);
            }

            mouse_event(MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, UIntPtr.Zero);
        }
        
        private void ClickDownAtPosition(int x, int y)
        {
            if (checkBoxAlternateClickStrategy.Checked)
            {
                SendInputClickStrategy.ClickDownAt(x, y);
                return;
            }
            
            // Move the cursor
            Cursor.Position = new Point(x, y);

            // Simulate mouse click
            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)x, (uint)y, 0, UIntPtr.Zero);
        }
        
        private void ReleaseClickAtPosition(int x, int y)
        {
            if (checkBoxAlternateClickStrategy.Checked)
            {
                SendInputClickStrategy.ClickUpAt(x, y);
                return;
            }
            
            // Move the cursor
            Cursor.Position = new Point(x, y);

            // Simulate mouse click
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, UIntPtr.Zero);
        }

        private async void buttonXyClick_Click(object sender, EventArgs e)
        {
            int.TryParse(numericXPos.Text, out int xPos);
            int.TryParse(numericYPos.Text, out int yPos);

            if (checkBoxClickHold.Checked)
            {
                ClickDownAtPosition(xPos, yPos);
                await Task.Delay((int)numericUpDownClickHoldDuration.Value * 1000);
                ReleaseClickAtPosition(xPos, yPos);
            }
            else
            {
                for (int i = 0; i <= numericClickCount.Value; i++)
                {
                    if (HALT_CLICKIES)
                    {
                        HALT_CLICKIES = false;
                        return;
                    }

                    ClickAtPosition(xPos, yPos);
                    await Task.Delay((int)numericClickDelay.Value);
                }                
            }
        }

        private async void buttonClickHold_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i <= numericClickCount.Value; i++)
            {
                if (HALT_CLICKIES)
                {
                    HALT_CLICKIES = false;
                    return;
                }

                int randX = random.Next(1920);
                int randY = random.Next(1080);

                ClickAtPosition(randX, randY);
                await Task.Delay((int)numericClickDelay.Value);
            }
        }

        #region Hotkey Support

        // Handle Windows messages
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == GlobalHotKey.WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == 1) // Our registered hotkey ID
                {
                    HALT_CLICKIES = true;
                    //MessageBox.Show("Global Hotkey (Ctrl + Shift + T) Pressed!", "Hotkey Triggered");
                }
            }
            base.WndProc(ref m);
        }

        // Unregister hotkey when the form closes
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            GlobalHotKey.UnegisterGlobalHotKey(Handle);
            base.OnFormClosing(e);
        }

        #endregion

        private void checkBoxClickHold_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxClickies.Enabled = !checkBoxClickHold.Checked;
        }

        private void numericUpDownPause_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPause.Value >= 0)
            {
                DownUpClickPause = (int)numericUpDownPause.Value;
            }
        }

        private void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this, checkBoxDarkMode.Checked);
        }
    }
}