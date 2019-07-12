using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDocies
{
    public partial class Cls : Form
    {
        public Cls()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://creativecommons.org/licenses/by-nc-nd/4.0/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
