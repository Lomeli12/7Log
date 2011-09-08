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
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Logon Hacks\Images\Default.jpg";
                textBox1.Text = "Returns the login text to its original state. Note!: Use at own risk!";
            }
            else if (listBox1.SelectedItem == "Darker Login Text Shadow")
            {
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Logon Hacks\Images\Darker Shadow.jpg";
                textBox1.Text = "Makes the login screen text shadow darker. Note!: Use at own risk!";
            }
            else if (listBox1.SelectedItem == "No Login Text Shadow")
            {
                pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\Logon Hacks\Images\No Shadow.jpg";
                textBox1.Text = "Removes the shadow from login screen text. Note!: Use at own risk!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == "Default Login Text Shadow")
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Logon Hacks\Default_Log_On_Text.reg");
            }
            else if (listBox1.SelectedItem == "Darker Login Text Shadow")
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Logon Hacks\Darker_Log_On_Text_Shadow.reg");
            }
            else if (listBox1.SelectedItem == "No Login Text Shadow")
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Logon Hacks\No_Log_On_Text_Shadow.reg");
            }
            MessageBox.Show("Please allow Windows to install the hack before proceeding.");
        }

        private void Loginhacks_Load(object sender, EventArgs e)
        {

        }
    }
}
