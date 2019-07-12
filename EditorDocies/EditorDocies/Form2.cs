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
            bitmap.Save(nome + ".png");
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

        private void Button4_Click(object sender, EventArgs e)
        {
            int p1=0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int p6 = 0;
            int p7 = 0;
            int p8 = 0;
            int p9 = 0;
            int p10 = 0;
            int p11 = 0;
            int p12 = 0;

            if (textBox1.Text != "")
            {
                 p1 = Convert.ToInt32(textBox1.Text);
                
            }
            

            if (textBox2.Text != "")
            {
                 p2 = Convert.ToInt32(textBox2.Text);
                lbNome.Location = new Point(p1, p2);
            }


            if (textBox3.Text != "")
            {
                 p3 = Convert.ToInt32(textBox3.Text);
                
            }
            if (textBox4.Text != "")
            {
                 p4 = Convert.ToInt32(textBox4.Text);
                lbAno.Location = new Point(p3, p4);
            }


            if (textBox5.Text != "")
            {
                 p5 = Convert.ToInt32(textBox5.Text);
                
            }
            if (textBox6.Text != "")
            {
                 p6 = Convert.ToInt32(textBox6.Text);
                lbMes.Location = new Point(p5, p6);
            }


            if (textBox7.Text != "")
            {
                 p7 = Convert.ToInt32(textBox7.Text);
                
            }
            if (textBox8.Text != "")
            {
                p8 = Convert.ToInt32(textBox8.Text);
                lbCd.Location = new Point(p7, p8);
            }


            if (textBox9.Text != "")
            {
                 p9 = Convert.ToInt32(textBox9.Text);
                
            }
            if (textBox10.Text != "")
            {
                 p10 = Convert.ToInt32(textBox10.Text);
                lbObs.Location = new Point(p9, p10);
            }


            if (textBox11.Text != "")
            {
                 p11 = Convert.ToInt32(textBox11.Text);
                
            }
            if (textBox12.Text != "")
            {
                 p12 = Convert.ToInt32(textBox12.Text);
                lbDep.Location = new Point(p11, p12);
            }







            
            
            
            

            
            
            
            
            
            
        }
    }
}
