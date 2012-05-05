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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _7Log
{
    public partial class Loginhacks : Form
    {
        public Loginhacks()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "Default Login Text Shadow")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Images\Default.jpg";
                textBox1.Text = "Returns the login text to its original state. Note!: Use at own risk!";
            }
            else if (listBox1.SelectedItem == "Darker Login Text Shadow")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Images\Darker Shadow.jpg";
                textBox1.Text = "Makes the login screen text shadow darker. Note!: Use at own risk!";
            }
            else if (listBox1.SelectedItem == "No Login Text Shadow")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Images\No Shadow.jpg";
                textBox1.Text = "Removes the shadow from login screen text. Note!: Use at own risk!";
            }
            else if (listBox1.SelectedItem == "Login Message")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Images\message_on_logon_screen.png";
                textBox1.Text = "Lets you add a message that appears before the user list appears.";
            }
            else if (listBox1.SelectedItem == "Login with Password")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Images\Default password.jpg";
                textBox1.Text = "Enables the default way to log into Windows by just asking for the Password for each account.";
            }
            else if (listBox1.SelectedItem == "Login with Password and Username")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Images\name and password.jpg";
                textBox1.Text = "Allows a more secure way to log into Windows by asking for both the Username and Password of an account.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey Texts = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI", true);
            RegistryKey Pass = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            if (listBox1.SelectedItem == "Default Login Text Shadow")
            {
                //System.Diagnostics.Process.Start(@"Logon Hacks\Default_Log_On_Text.reg");
                Texts.SetValue("ButtonSet", 0, RegistryValueKind.DWord);
                MessageBox.Show("Hack applied");
            }
            else { }
            if (listBox1.SelectedItem == "Darker Login Text Shadow")
            {
                //System.Diagnostics.Process.Start(@"Logon Hacks\Darker_Log_On_Text_Shadow.reg");
                Texts.SetValue("ButtonSet", 1, RegistryValueKind.DWord);
                MessageBox.Show("Hack applied");
            }
            else { }
            if (listBox1.SelectedItem == "No Login Text Shadow")
            {
                //System.Diagnostics.Process.Start(@"Logon Hacks\No_Log_On_Text_Shadow.reg");
                Texts.SetValue("ButtonSet", 2, RegistryValueKind.DWord);
                MessageBox.Show("Hack applied");
            }
            else { }
            if (listBox1.SelectedItem == "Login with Password")
            {
                //System.Diagnostics.Process.Start(@"Logon Hacks\No_Log_On_Text_Shadow.reg");
                Pass.SetValue("dontdisplaylastusername", 0, RegistryValueKind.DWord);
                MessageBox.Show("Hack applied");
            }
            else { }
            if (listBox1.SelectedItem == "Login with Password and Username")
            {
                //System.Diagnostics.Process.Start(@"Logon Hacks\No_Log_On_Text_Shadow.reg");
                Pass.SetValue("dontdisplaylastusername", 1, RegistryValueKind.DWord);
                MessageBox.Show("Hack applied");
            }
            else { }
            if (listBox1.SelectedItem == "Login Message")
            {
                LoginHackGUI4 loginmess = new LoginHackGUI4();
                loginmess.ShowDialog();
            }
            else { }
        }

    }
}
