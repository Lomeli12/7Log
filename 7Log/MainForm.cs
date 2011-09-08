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
using Geeks.ImageOptimizer.API;
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
            /* Checks if the user is using Windows Vista or Windows 7
            ConfirmOS ConOs = new ConfirmOS();
            if (System.IO.Directory.Exists(@"\System\") == false)
            {
                if (Environment.OSVersion.Version.Build <= 6999)
                {
                    ConOs.TextValue1 = "7Log has determined that you are using a version of Windows Vista. Is that true.";
                    ConOs.TextValue2 = "Yes, I'm using Windows Vista";
                    ConOs.TextValue3 = "No, I'm using Windows 7";
                    ConOs.OS1 = "Vista";
                    ConOs.OS2 = "7";
                    ConOs.ShowDialog();
                }
                else if (Environment.OSVersion.Version.Build >= 7600)
                {
                    ConOs.TextValue1 = "7Log has determined that you are using a version of Windows 7. Is that true.";
                    ConOs.TextValue2 = "Yes, I'm using Windows 7";
                    ConOs.TextValue3 = "No, I'm using Windows Vista";
                    ConOs.OS1 = "7";
                    ConOs.OS2 = "Vista";
                    ConOs.ShowDialog();
                }
                else if (Environment.OSVersion.Version.Build < 6000)
                {
                    MessageBox.Show("Your OS is not supported");
                    Application.Exit();
                }
            }
            else if (System.IO.Directory.Exists(@"\System\") == true)
            {
                if (System.IO.File.Exists(@"\System\7.7sav") == true)
                {
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

                    }
                    else if (System.IO.Directory.Exists(@"C:\Windows\System32\oobe\info\backgrounds") == false)
                    {
                        System.IO.Directory.CreateDirectory(@"C:\Windows\System32\oobe\info\backgrounds");
                        MessageBox.Show("Backgrounds folder created!");
                    }
                }
                else if (System.IO.File.Exists(@"\System\Vista.7sav") == true)
                {
                    lgoinHacksToolStripMenuItem.Enabled = false;
                    button2.Enabled = false;
                    recreateBackgroundFolderToolStripMenuItem.Enabled = false;
                    reinstallOEMBackgroundToolStripMenuItem.Enabled = false;
                }
            }
             */
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
            //the following detects the size of the file in byets
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(openFileDialog1.FileName);
            if (fileInfo.Length > 262144)
            {
                //optimiezs the file size to fit your screen and shrink the size.
                //Checks to see if there is already a login file in use, and deletes it if is.
                if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == true)
                {
                    ImageOptimizer optimizer = new ImageOptimizer(); 
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    System.IO.File.Delete(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                    optimizer.Optimize(openFileDialog1.FileName, @"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                    textBox1.Text = openFileDialog1.FileName;
                }
                else if (System.IO.File.Exists(@"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg") == false)
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    ImageOptimizer optimizer = new ImageOptimizer();
                    optimizer.Optimize(openFileDialog1.FileName, @"C:\Windows\System32\oobe\info\backgrounds\backgroundDefault.jpg");
                    textBox1.Text = openFileDialog1.FileName;
                }
                MessageBox.Show("Login successfully applied!");
            }
            else if (fileInfo.Length <= 262144)
            {
                //runs 7Log normally.
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
                MessageBox.Show("Login successfully applied!");
            }
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
            System.Diagnostics.Process.Start("http://anthony-lomeli.co.cc/?page_id=13");
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