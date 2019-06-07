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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btSub_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.lbNome.Text = txtNome.Text;
            f2.lbAno.Text = txtAno.Text;
            f2.lbMes.Text = txtMes.Text;
            f2.lbCd.Text = txtcd.Text;
            f2.lbObs.Text = txtobs.Text;
            f2.lbDep.Text = txtdep.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Save(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nome do ficheiro")
            {
                textBox1.ResetText();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nome do ficheiro";
            }
        }
    }
}
