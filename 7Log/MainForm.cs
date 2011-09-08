/*
 * This comment is added to every CS file in order to prove to state
 * the original creator of the source code, me, Anthony Lomeli.
 * 
 * Each original CS File MUST have this comment embedded somewhere in it
 * for its use.
 * 
 * Any files created by the user of the source code does not need this comment embedded.
 * 
 * Deleting this comment will violate the terms of agreement between the author and
 * source code user and thus be counted as copyright infringement in a court of law.
 * 
 * Please note this is just a safety percaution. I apologize for any inconvience.
 * 
 * - Anthony Lomeli
 *  Author of 7Log
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7Log
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            if(System.IO.File.Exists("C:\\Windows\\System32\\oobe\\info\\backgrounds\\backgroundDefault.jpg") == true){
                pictureBox1.ImageLocation = "C:\\Windows\\System32\\oobe\\info\\backgrounds\\backgroundDefault.jpg";
                textBox1.Text = "Current Login Background";
            }
            else if(System.IO.File.Exists("C:\\Windows\\System32\\oobe\\info\\backgrounds\\backgroundDefault.jpg") == false){
                textBox1.Text = "Default Login Background";
            }
            if (System.IO.Directory.Exists("C:\\Windows\\System32\\oobe\\info\\backgrounds") == true)
            {

            }
            else if (System.IO.Directory.Exists("C:\\Windows\\System32\\oobe\\info\\backgrounds") == false)
            {
                System.IO.Directory.CreateDirectory("C:\\Windows\\System32\\oobe\\info\\backgrounds");
                MessageBox.Show("Backgrounds folder");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=86XKATDATCJRW&lc=US&item_name=AnthonyL&item_number=123&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void selectALoginImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(openFileDialog1.FileName);
            if (fileInfo.Length > 262144)
            {
                MessageBox.Show("Image is too large to use. Crop it or shrink it till its less than 250KB.");
            }
            else if (fileInfo.Length <= 262144)
            {
                MessageBox.Show("Login successfully applied!");
                if(System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    System.IO.File.Delete(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, @"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                    textBox1.Text = openFileDialog1.FileName;
                }
                else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    System.IO.File.Copy(openFileDialog1.FileName, @"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                    textBox1.Text = openFileDialog1.FileName;
                }
            }
        }

        private void restoreLoginBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
            {
                System.IO.File.Delete(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                MessageBox.Show("Login successfully restored.");
            }
            else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
            {
                MessageBox.Show("There is no custom login.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://browse.deviantart.com/customization/wallpaper/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
            {
                System.IO.File.Delete(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                pictureBox1.ImageLocation = "C:\\Windows\\System32\\oobe\\info\\background.bmp";
                MessageBox.Show("Login successfully restored.");
            }
            else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
            {
                MessageBox.Show("There is no custom login.");
            }
        }

        private void recreateBackgroundFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\Windows\System32\oobe\info\backgrounds") == false)
            {
                System.IO.Directory.CreateDirectory(@"C:\Windows\System32\oobe\info\backgrounds");
                MessageBox.Show("Directory created.");
            }
            else if (System.IO.Directory.Exists(@"C:\Windows\System32\oobe\info\backgrounds") == true)
            {
                MessageBox.Show("Backgrounds directory already exists");
            }
        }

        private void reinstallOEMBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\OEMBackground.reg");
        }

        private void viewPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Manual.PDF");
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://anthony-lomeli.co.cc/?page_id=13");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutwin = new About();
            aboutwin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loginhacks Hack = new Loginhacks();
            Hack.ShowDialog();
        }

        private void lgoinHacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginhacks Hack = new Loginhacks();
            Hack.ShowDialog();
        }
    }
}
