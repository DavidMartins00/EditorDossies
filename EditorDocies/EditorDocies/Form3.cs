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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        Form2 f2 = new Form2();
        public Image img = Properties.Resources.docie20;
        public string tst = "docie20";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.docie20;
            f2.img = Properties.Resources.docie20;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.docie3;
            f2.img= Properties.Resources.docie3;
            tst = "docie3";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.docie4;
            f2.img = Properties.Resources.docie4;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.docie5;
            f2.img = Properties.Resources.docie5;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.docie6;
            f2.img = Properties.Resources.docie6;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.docie7;
            f2.img = Properties.Resources.docie7;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.docie8;
            f2.img = Properties.Resources.docie8;
        }
    }
}
