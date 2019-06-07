using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDocies
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static Form1 f = new Form1();
        public void Save(string nom)
        {
            Size ss = new Size(400, 1080);
            Bitmap bitmap = new Bitmap(315,900);
            Graphics graphics = Graphics.FromImage(bitmap);
            
            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            graphics.CopyFromScreen(this.Location,Point.Empty, ss);
            bitmap.Save(nom + ".png");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Save(f.textBox1.Text);
            MessageBox.Show("asdasdad");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
