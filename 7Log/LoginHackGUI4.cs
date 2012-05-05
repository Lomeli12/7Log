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
    public partial class LoginHackGUI4 : Form
    {
        public LoginHackGUI4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey Title = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            RegistryKey Textl = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            Title.SetValue("legalnoticecaption", textBox1.Text, RegistryValueKind.String);
            Textl.SetValue("legalnoticetext", textBox2.Text, RegistryValueKind.String);
            MessageBox.Show("Login Message applied");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey Title = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            RegistryKey Textl = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            Title.SetValue("legalnoticecaption", "", RegistryValueKind.String);
            Textl.SetValue("legalnoticetext", "", RegistryValueKind.String);
            MessageBox.Show("Login Message removed");
        }

    }
}
