using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWedka
{
    public partial class Form1 : Form
    {
        Point Pos;
        bool mDown = false;
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);


        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);


        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        IntPtr hWnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel_titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Pos.X = e.X;
            Pos.Y = e.Y;
            mDown = true;
        }

        private void panel_titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDown)
            {
                Point currPos = PointToScreen(e.Location);
                Location = new Point(currPos.X - Pos.X, currPos.Y - Pos.Y);
            }
        }

        private void panel_titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }

        private void bind_button_Click(object sender, EventArgs e)
        {
            if(bind_button.Text == "brak")
            {
                bind_button.Text = "***";
            }
            else
            {
                bind_button.Text = "***";
            }
        }

        private void bind_button_KeyDown(object sender, KeyEventArgs e)
        {
            if(bind_button.Text == "***")
            {
                bind_button.Text = e.KeyData.ToString();
                if(GetAsyncKeyState(Keys.Escape) < 0)
                {
                    bind_button.Text = "brak";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KeysConverter kc = new KeysConverter();
            if(bind_button.Text != "brak" && bind_button.Text != "***")
            {
                Keys kk = (Keys)kc.ConvertFromString(bind_button.Text);
                if (GetAsyncKeyState(kk) < 0)
                {
                    if (checkBox.Checked)
                    {
                        checkBox.Checked = false;
                    }
                    else
                    {
                        checkBox.Checked = true;
                    }
                }
            }
        }


        private async void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                Process[] prc = Process.GetProcessesByName("javaw");
                foreach (Process p in prc)
                {
                    hWnd = FindWindow(null, p.MainWindowTitle);
                }


                await Task.Delay(30);
                SendKeys.Send(slot_wedki.Text);
                await Task.Delay(40);
                PostMessage(hWnd, 0x204, 0, 0);
                await Task.Delay(30);
                PostMessage(hWnd, 0x205, 0, 0);
                await Task.Delay(40);
                SendKeys.Send(slot_mieczyka.Text);
                checkBox.Checked = false;
            }
        }
    }
}
