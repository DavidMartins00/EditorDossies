namespace EditorDocies
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSub = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Empresa:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(126, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(118, 51);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(126, 22);
            this.txtAno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano:";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(118, 91);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(126, 22);
            this.txtMes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mês:";
            // 
            // txtcd
            // 
            this.txtcd.Location = new System.Drawing.Point(114, 165);
            this.txtcd.Multiline = true;
            this.txtcd.Name = "txtcd";
            this.txtcd.Size = new System.Drawing.Size(206, 88);
            this.txtcd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Conteudo do dossie:";
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(114, 275);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(206, 66);
            this.txtobs.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observações:";
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(118, 129);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(126, 22);
            this.txtdep.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Departamento:";
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(103, 461);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(141, 46);
            this.btSub.TabIndex = 8;
            this.btSub.Text = "Submeter";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EditorDocies.Properties.Resources.docie20;
            this.pictureBox1.Location = new System.Drawing.Point(315, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(216, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Escolher Cor:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 519);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.txtdep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Editor Dossies";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSub;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtAno;
        public System.Windows.Forms.TextBox txtMes;
        public System.Windows.Forms.TextBox txtcd;
        public System.Windows.Forms.TextBox txtobs;
        public System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

