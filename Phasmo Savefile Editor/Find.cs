using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Phasmo_Savefile_Editor.Form1;

namespace Phasmo_Savefile_Editor
{
    public partial class Find : Form
    {

        public static class Constants
        {
            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);

        public Find()
        {
            InitializeComponent();

            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Clear();
            string[] words = textBox1.Text.Split(',');
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < Form1.richTextBox1.TextLength)
                {
                    int wordstartIndex = Form1.richTextBox1.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        Form1.richTextBox1.SelectionStart = wordstartIndex;
                        Form1.richTextBox1.SelectionLength = word.Length;
                        Form1.richTextBox1.SelectionBackColor = Color.Yellow;
                        Form1.richTextBox1.SelectionColor = Color.Black;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Clear()
        {
            Form1.richTextBox1.SelectionStart = 0;
            Form1.richTextBox1.SelectAll();
            Form1.richTextBox1.SelectionBackColor = Color.FromArgb(33, 33, 33);
            Form1.richTextBox1.SelectionColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            string[] words = textBox1.Text.Split(',');
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < Form1.richTextBox1.TextLength)
                {
                    int wordstartIndex = Form1.richTextBox1.Find(word, startindex, RichTextBoxFinds.None);
                    break;
                }
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
