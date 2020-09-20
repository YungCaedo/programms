using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClickBotInterface
{
    public partial class Form1 : Form
    {
        private const UInt32 MouseEventLeftDown = 0x0002;
        private const UInt32 MouseEventLeftUp = 0x0004;
        private const UInt32 MouseEventRightDown = 0x08;
        private const UInt32 MouseEventRightUp = 0x10;
        private const UInt32 MouseEventMiddleDown = 0x0020;
        private const UInt32 MouseEventMiddleUp = 0x0040;

        [DllImport("user32", EntryPoint = "mouse_event")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);


        public static string mouseButton;
        public static string mode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dropMaustaste_SelectedIndexChanged(object sender, EventArgs e)
        {
            mouseButton = dropMaustaste.SelectedItem.ToString();
        }

        private void dropMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = dropMode.SelectedItem.ToString();
            if(mode == "Halten")
            {
                inputDelay.Enabled = false;
                timer1.Interval = 1;
            }
            else
            {
                inputDelay.Enabled = true;
                timer1.Interval = (int) inputDelay.Value;
            }
        }

        private void inputDelay_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int) inputDelay.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            mouse_event(MouseEventMiddleUp, 960, 600, 0, new System.IntPtr());
            mouse_event(MouseEventLeftUp, 960, 600, 0, new System.IntPtr());
            mouse_event(MouseEventRightUp, 960, 600, 0, new System.IntPtr());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.mode == "Klicken")
            {
                if (Form1.mouseButton == "Links")
                {
                    mouse_event(MouseEventLeftDown, 960, 600, 0, new System.IntPtr());
                    mouse_event(MouseEventLeftUp, 960, 600, 0, new System.IntPtr());
                }
                else if(Form1.mouseButton == "Rechts")
                {
                    mouse_event(MouseEventRightDown, 960, 600, 0, new System.IntPtr());
                    mouse_event(MouseEventRightUp, 960, 600, 0, new System.IntPtr());
                }
                else if (Form1.mouseButton == "Mitte")
                {
                    mouse_event(MouseEventMiddleDown, 960, 600, 0, new System.IntPtr());
                    mouse_event(MouseEventMiddleUp, 960, 600, 0, new System.IntPtr());
                }
            }
            else
            {
                if (Form1.mouseButton == "Links")
                {
                    mouse_event(MouseEventLeftDown, 960, 600, 0, new System.IntPtr());
                }
                else if (Form1.mouseButton == "Mitte")
                {
                    mouse_event(MouseEventMiddleDown, 960, 600, 0, new System.IntPtr());
                }
                else if (Form1.mouseButton == "Rechts")
                {
                    mouse_event(MouseEventRightDown, 960, 600, 0, new System.IntPtr());
                }
            }
        }
    }
}
