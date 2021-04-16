namespace proyectoDisney_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.disneyBtt = new System.Windows.Forms.Button();
            this.pixarBtn = new System.Windows.Forms.Button();
            this.marvelBtn = new System.Windows.Forms.Button();
            this.SWbtn = new System.Windows.Forms.Button();
            this.natgeoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // disneyBtt
            // 
            this.disneyBtt.BackColor = System.Drawing.Color.Transparent;
            this.disneyBtt.BackgroundImage = global::proyectoDisney_.Properties.Resources.disney;
            this.disneyBtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.disneyBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disneyBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disneyBtt.Location = new System.Drawing.Point(12, 12);
            this.disneyBtt.Name = "disneyBtt";
            this.disneyBtt.Size = new System.Drawing.Size(118, 54);
            this.disneyBtt.TabIndex = 0;
            this.disneyBtt.UseVisualStyleBackColor = false;
            this.disneyBtt.Click += new System.EventHandler(this.button1_Click);
            // 
            // pixarBtn
            // 
            this.pixarBtn.BackColor = System.Drawing.Color.Transparent;
            this.pixarBtn.BackgroundImage = global::proyectoDisney_.Properties.Resources.pixar;
            this.pixarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pixarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pixarBtn.Location = new System.Drawing.Point(136, 14);
            this.pixarBtn.Name = "pixarBtn";
            this.pixarBtn.Size = new System.Drawing.Size(118, 54);
            this.pixarBtn.TabIndex = 1;
            this.pixarBtn.UseVisualStyleBackColor = false;
            this.pixarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // marvelBtn
            // 
            this.marvelBtn.BackColor = System.Drawing.Color.Transparent;
            this.marvelBtn.BackgroundImage = global::proyectoDisney_.Properties.Resources.marvelLogo;
            this.marvelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.marvelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marvelBtn.Location = new System.Drawing.Point(260, 14);
            this.marvelBtn.Name = "marvelBtn";
            this.marvelBtn.Size = new System.Drawing.Size(118, 54);
            this.marvelBtn.TabIndex = 2;
            this.marvelBtn.UseVisualStyleBackColor = false;
            this.marvelBtn.Click += new System.EventHandler(this.marvelBtn_Click);
            // 
            // SWbtn
            // 
            this.SWbtn.BackColor = System.Drawing.Color.Transparent;
            this.SWbtn.BackgroundImage = global::proyectoDisney_.Properties.Resources.star_wars1;
            this.SWbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SWbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWbtn.Location = new System.Drawing.Point(384, 12);
            this.SWbtn.Name = "SWbtn";
            this.SWbtn.Size = new System.Drawing.Size(118, 54);
            this.SWbtn.TabIndex = 3;
            this.SWbtn.UseVisualStyleBackColor = false;
            this.SWbtn.Click += new System.EventHandler(this.SWbtn_Click);
            // 
            // natgeoBtn
            // 
            this.natgeoBtn.BackColor = System.Drawing.Color.Transparent;
            this.natgeoBtn.BackgroundImage = global::proyectoDisney_.Properties.Resources.national_geographic1;
            this.natgeoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.natgeoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.natgeoBtn.Location = new System.Drawing.Point(508, 12);
            this.natgeoBtn.Name = "natgeoBtn";
            this.natgeoBtn.Size = new System.Drawing.Size(118, 54);
            this.natgeoBtn.TabIndex = 4;
            this.natgeoBtn.UseVisualStyleBackColor = false;
            this.natgeoBtn.Click += new System.EventHandler(this.natgeoBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(32, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoDisney_.Properties.Resources.backgroundFeed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.natgeoBtn);
            this.Controls.Add(this.SWbtn);
            this.Controls.Add(this.marvelBtn);
            this.Controls.Add(this.pixarBtn);
            this.Controls.Add(this.disneyBtt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button disneyBtt;
        private System.Windows.Forms.Button pixarBtn;
        private System.Windows.Forms.Button marvelBtn;
        private System.Windows.Forms.Button SWbtn;
        private System.Windows.Forms.Button natgeoBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

