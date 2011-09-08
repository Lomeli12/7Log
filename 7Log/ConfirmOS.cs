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
    public partial class ConfirmOS : Form
    {
        public ConfirmOS()
        {
            InitializeComponent();
        }

        public string TextValue1
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string TextValue2
        {
            get { return radioButton1.Text; }
            set { radioButton1.Text = value; }
        }
        public string TextValue3
        {
            get { return radioButton2.Text; }
            set { radioButton2.Text = value; }
        }
        public string OS1;
        public string OS2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                System.IO.Directory.CreateDirectory(@"\System");
                System.IO.File.Create(@"\System\" + OS1 + ".7sav");
                MessageBox.Show("7Log will restart.");
                Application.Exit();
            }
            else if(radioButton2.Checked == true)
            {
                System.IO.Directory.CreateDirectory(@"\System");
                System.IO.File.Create(@"\System\" + OS2 + ".7sav");
                MessageBox.Show("7Log will restart.");
                Application.Exit();
            }
            else if (radioButton3.Checked == true)
            {
                Application.Exit();
            }
        }
    }
}
