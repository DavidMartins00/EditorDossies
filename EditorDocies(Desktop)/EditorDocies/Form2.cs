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
using System.Drawing.Printing;

namespace EditorDocies
{
    public partial class Form2 : Form
    {

        static Form1 f = new Form1();
        static Form3 f3 = new Form3();
        public string nome;
        public Image img;
        Bitmap bitmap = new Bitmap(300, 900);

        public Form2()
        {
            InitializeComponent();
        }
        
        public void Save()
        {
            Size ss = new Size(400, 1080);
            Graphics graphics = Graphics.FromImage(bitmap);
            
            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            graphics.CopyFromScreen(this.Location,Point.Empty, ss);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            menuStrip1.Visible = false;
            Save();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            menuStrip1.Visible = true;
            bitmap.Save("imagem.png");
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
            this.Hide();
            PerformAutoScale();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            menuStrip1.Visible = false;
            Save();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            menuStrip1.Visible = true;
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        { 
            System.Drawing.Image img = bitmap;
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);
        }
    }
}
