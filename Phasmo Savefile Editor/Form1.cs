using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Phasmo_Savefile_Editor
{
    public partial class Form1 : Form
    {
        Find find = new Find();
        public static RichTextBox richTextBox1 = new RichTextBox();

        public Form1()
        {
            InitializeComponent();

            find.Hide();
        // rounded border
        var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));

            // base64
            Microsoft.Win32.RegistryKey savefileKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Phasmophobia Savefile Editor");
            if (savefileKey.GetValue("SavedText") == null)
            {
                savefileKey.SetValue("SavedText", "N/A");
                savefileKey.Close();
            }
            else
            {
                try
                {
                    byte[] decodedBytes = Convert.FromBase64String(savefileKey.GetValue("SavedText").ToString());
                    richTextBox1.Text = Encoding.UTF8.GetString(decodedBytes);
                    savefileKey.Close();
                }
                catch
                {
                    return;
                }
            }

        }

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
            DWMWCP_ROUND = 4,
            DWMWCP_ROUNDSMALL = 3
        }

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);


        private void encryptBtn_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[16];
            using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngcryptoServiceProvider.GetBytes(array);
            }
            string s = "t36gref9u84y7f43g";
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            try
            {
                using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 100))
                {
                    ICryptoTransform transform = new RijndaelManaged
                    {
                        KeySize = 128,
                        BlockSize = 128,
                        Mode = CipherMode.CBC,
                        Padding = PaddingMode.PKCS7
                    }.CreateEncryptor(rfc2898DeriveBytes.GetBytes(16), array);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                        {
                            byte[] array2 = Encoding.UTF8.GetBytes(richTextBox1.Text);
                            cryptoStream.Write(array2, 0, array2.Length);
                        }
                        byte[] array3 = memoryStream.ToArray();
                        byte[] array4 = new byte[array.Length + array3.Length];
                        Buffer.BlockCopy(array, 0, array4, 0, array.Length);
                        Buffer.BlockCopy(array3, 0, array4, array.Length, array3.Length);
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.DefaultExt = "TXT";
                        saveFileDialog.Filter = "TXT Files (*.txt)|*.txt|All Files (*.*)|*.*";
                        saveFileDialog.ShowDialog();
                        if (saveFileDialog.FileName == "")
                        {
                            MessageBox.Show("The location cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, array4);
                            MessageBox.Show("File encrypted and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
                MessageBox.Show("Failed to encrypt the file. Please try again." + value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                string fileName = openFileDialog.FileName;
                byte[] array = File.ReadAllBytes(fileName);
                string text = "t36gref9u84y7f43g";
                bool flag2 = string.IsNullOrEmpty(text);
                if (flag2)
                {
                    MessageBox.Show("Please provide a decryption password");
                }
                else
                {
                    byte[] array2 = new byte[16];
                    Array.Copy(array, array2, 16);
                    byte[] array3 = new byte[array.Length - 16];
                    Array.Copy(array, 16, array3, 0, array.Length - 16);
                    try
                    {
                        Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(text, array2, 100);
                        byte[] bytes = rfc2898DeriveBytes.GetBytes(16);
                        using (Aes aes = Aes.Create())
                        {
                            aes.Mode = CipherMode.CBC;
                            aes.Padding = PaddingMode.PKCS7;
                            aes.Key = bytes;
                            aes.IV = array2;
                            ICryptoTransform transform = aes.CreateDecryptor();
                            using (MemoryStream memoryStream = new MemoryStream(array3))
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
                                {
                                    using (StreamReader streamReader = new StreamReader(cryptoStream))
                                    {
                                        string contents = streamReader.ReadToEnd();
                                        richTextBox1.Text = contents;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Decryption error: " + ex.Message);
                        MessageBox.Show("Decryption error: Please make sure you're selecting the 'SaveFile' not the 'SaveData'");
                    }
                }
            }
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimiseBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] bytesToEncode = Encoding.UTF8.GetBytes(richTextBox1.Text);

            //open key
            Microsoft.Win32.RegistryKey savedTextKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Phasmophobia Savefile Editor");

            savedTextKey.SetValue("SavedText", Convert.ToBase64String(bytesToEncode).ToString());
            savedTextKey.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process? process = Process.Start(new ProcessStartInfo("http://turbowarp.org/992603556?fps=60&clones=Infinity&offscreen&limitless&interpolate")
            {
                UseShellExecute = true
            });

            process!.WaitForExit();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (find.ToString() == "Phasmo_Savefile_Editor.Find, Text: ")
            {
                find = new Find();
            }
            find.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
