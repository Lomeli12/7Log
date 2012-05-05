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
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

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
            //Checks if a custom login is in use.
            if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
                {
                    pictureBox1.ImageLocation = @"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg";
                    textBox1.Text = "Current Login Background";
                }
            else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
                {
                    textBox1.Text = "Default Login Background";
                }
            if (System.IO.Directory.Exists(@"C:\Windows\System32\oobe\info\backgrounds") == true)
                {
                    //do nothing
                }
            else if (System.IO.Directory.Exists(@"C:\Windows\System32\oobe\info\backgrounds") == false)
                {
                    System.IO.Directory.CreateDirectory(@"C:\Windows\System32\oobe\info\backgrounds");
                    MessageBox.Show("Backgrounds folder created!");
                 }
        }

        private void button5_Click(object sender, EventArgs e)//Donate to me!
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=86XKATDATCJRW&lc=US&item_name=AnthonyL&item_number=123&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//Closes the program
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Open the picture dialog box through a button
        {
            openFileDialog1.ShowDialog();
        }

        private void selectALoginImageToolStripMenuItem_Click(object sender, EventArgs e)//Open the picture dialog box through the menu
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)//Applying the login background
        {
        	int width = Screen.PrimaryScreen.Bounds.Width;
        	int height = Screen.PrimaryScreen.Bounds.Height;
            //optimiezs the file size to fit your screen and shrink the size.
            //Checks to see if there is already a login file in use, and deletes it if is.
            if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                System.IO.File.Delete(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                Bitmap bmp = new Bitmap(Image.FromFile(openFileDialog1.FileName), new Size(width, height));
                bmp.Save(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg", ImageFormat.Jpeg);
                bmp.Dispose();
                textBox1.Text = openFileDialog1.FileName;
            }
             else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                Bitmap bmp = new Bitmap(Image.FromFile(openFileDialog1.FileName), new Size(width, height));
                bmp.Save(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg", ImageFormat.Jpeg);
                bmp.Dispose();
                textBox1.Text = openFileDialog1.FileName;
            }
                MessageBox.Show("Login successfully applied!");
        }

        private void restoreLoginBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Restores the orginal login background by deleting the custom one, if one is in use.
            if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
            {
                System.IO.File.Delete(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                textBox1.Text = "Default Login Background";
                MessageBox.Show("Login successfully restored.");
            }
            else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
            {
                MessageBox.Show("There is no custom login.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Goes to deviantart to look for wallpaper
            System.Diagnostics.Process.Start("http://browse.deviantart.com/customization/wallpaper/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Restores the orginal login background by deleting the custom one, if one is in use.
            if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
            {
                System.IO.File.Delete(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                pictureBox1.ImageLocation = @"C:\Windows\System32\oobe\info\background.bmp";
                textBox1.Text = "Default Login Background";
                MessageBox.Show("Login successfully restored.");
            }
            else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
            {
                MessageBox.Show("There is no custom login.");
            }
        }

        private void recreateBackgroundFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Recreates the "Backgrounds" folder in system32 incase it was deleted and 7Log failed to detect it.
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
            //reinstalls OEMBackground, the Registry key required to use custom backgrounds
            RegistryKey BG = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI\\Background", true);
            BG.SetValue("OEMBackground", 1, RegistryValueKind.DWord);
        }

        private void viewPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens the user manual for 7Log
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Manual.PDF");
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GOES TO MY WEBSITE!
            System.Diagnostics.Process.Start("http://anthony-lomeli.co.cc/programs/7log-2");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens the about box
            About aboutwin = new About();
            aboutwin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Opens the loginhacks main window
            Loginhacks Hack = new Loginhacks();
            Hack.ShowDialog();
        }

        private void lgoinHacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //same as the code above.
            Loginhacks Hack = new Loginhacks();
            Hack.ShowDialog();
        }
    }
}
/*
 * This comment is added to every CS file in order to state
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
 *   Author of 7Log
*/