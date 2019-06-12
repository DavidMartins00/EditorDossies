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

        static Form1 f = new Form1();
        static Form3 f3 = new Form3();
        public string nome;
        public Image img;
        public Form2()
        {
            InitializeComponent();
        }
        int sopa;

        public void Save(string nom)
        {
            button1.Visible = false;
            Size ss = new Size(400, 1080);
            Bitmap bitmap = new Bitmap(300,900);
            Graphics graphics = Graphics.FromImage(bitmap);
            
            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            graphics.CopyFromScreen(this.Location,Point.Empty, ss);
            bitmap.Save(nom + ".png");
            button1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            Save(nome);
            button2.Visible = true;

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            img = f.pictureBox1.Image;
            this.BackgroundImage = img;
            pictureBox1.Image =img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Application.Exit();
        }
    }
}
