namespace EditorDocies
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbMes = new System.Windows.Forms.Label();
            this.lbCd = new System.Windows.Forms.Label();
            this.lbObs = new System.Windows.Forms.Label();
            this.lbDep = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(83, 57);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(137, 29);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome EMP";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.BackColor = System.Drawing.Color.Transparent;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(123, 237);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(55, 29);
            this.lbAno.TabIndex = 2;
            this.lbAno.Text = "Ano";
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.BackColor = System.Drawing.Color.Transparent;
            this.lbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(123, 283);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(59, 29);
            this.lbMes.TabIndex = 3;
            this.lbMes.Text = "Mes";
            // 
            // lbCd
            // 
            this.lbCd.AutoEllipsis = true;
            this.lbCd.BackColor = System.Drawing.Color.Transparent;
            this.lbCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCd.Location = new System.Drawing.Point(37, 357);
            this.lbCd.Name = "lbCd";
            this.lbCd.Size = new System.Drawing.Size(239, 273);
            this.lbCd.TabIndex = 4;
            this.lbCd.Text = "Conteudo do dossie";
            // 
            // lbObs
            // 
            this.lbObs.AutoEllipsis = true;
            this.lbObs.BackColor = System.Drawing.Color.Transparent;
            this.lbObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObs.Location = new System.Drawing.Point(37, 649);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(199, 52);
            this.lbObs.TabIndex = 6;
            this.lbObs.Text = "Obs";
            // 
            // lbDep
            // 
            this.lbDep.AutoEllipsis = true;
            this.lbDep.BackColor = System.Drawing.Color.Transparent;
            this.lbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDep.Location = new System.Drawing.Point(42, 750);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(234, 90);
            this.lbDep.TabIndex = 7;
            this.lbDep.Text = "Depart";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(21, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 79);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EditorDocies.Properties.Resources.docie20;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 1033);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 1033);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDep);
            this.Controls.Add(this.lbObs);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbCd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.Label lbAno;
        public System.Windows.Forms.Label lbMes;
        public System.Windows.Forms.Label lbCd;
        public System.Windows.Forms.Label lbObs;
        public System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}