using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleClock
{
    public partial class SimpleClock : Form
    {
        /*// variables on declaration (always on top)
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        */
        public SimpleClock()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            //SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS); // ExE function (always on top)
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                btn_exit.Hide();
                this.Height = 125;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readable.Text = DateTime.Now.ToString();
            unixtime.Text = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        }

        private void copy_readable_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(readable.Text);
        }

        private void copy_unix_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(unixtime.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                unixtime.Show();
            }
            else
            {
                unixtime.Hide();
            }
        }
        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                readable.Show();
            }
            else
            {
                readable.Hide();
            }
        }
        /*
        Constants in Windows API
        0x84 = WM_NCHITTEST - Mouse Capture Test
        0x1 = HTCLIENT - Application Client Area
        0x2 = HTCAPTION - Application Title Bar

        This function intercepts all the commands sent to the application. 
        It checks to see of the message is a mouse click in the application. 
        It passes the action to the base action by default. It reassigns 
        the action to the title bar if it occured in the client area
        to allow the drag and move behavior.
        */
        // Thanks LizB@Stackoverflow.com
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}