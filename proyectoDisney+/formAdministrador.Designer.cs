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
            this.disneyBtt = new System.Windows.Forms.Button();
            this.pixarBtn = new System.Windows.Forms.Button();
            this.marvelBtn = new System.Windows.Forms.Button();
            this.SWbtn = new System.Windows.Forms.Button();
            this.natgeoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disneyBtt
            // 
            this.disneyBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disneyBtt.Location = new System.Drawing.Point(13, 105);
            this.disneyBtt.Name = "disneyBtt";
            this.disneyBtt.Size = new System.Drawing.Size(118, 54);
            this.disneyBtt.TabIndex = 0;
            this.disneyBtt.Text = "Disney";
            this.disneyBtt.UseVisualStyleBackColor = true;
            this.disneyBtt.Click += new System.EventHandler(this.button1_Click);
            // 
            // pixarBtn
            // 
            this.pixarBtn.Location = new System.Drawing.Point(137, 105);
            this.pixarBtn.Name = "pixarBtn";
            this.pixarBtn.Size = new System.Drawing.Size(118, 54);
            this.pixarBtn.TabIndex = 1;
            this.pixarBtn.Text = "PIXAR";
            this.pixarBtn.UseVisualStyleBackColor = true;
            this.pixarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // marvelBtn
            // 
            this.marvelBtn.Location = new System.Drawing.Point(261, 105);
            this.marvelBtn.Name = "marvelBtn";
            this.marvelBtn.Size = new System.Drawing.Size(118, 54);
            this.marvelBtn.TabIndex = 2;
            this.marvelBtn.Text = "MARVEL";
            this.marvelBtn.UseVisualStyleBackColor = true;
            this.marvelBtn.Click += new System.EventHandler(this.marvelBtn_Click);
            // 
            // SWbtn
            // 
            this.SWbtn.Location = new System.Drawing.Point(385, 105);
            this.SWbtn.Name = "SWbtn";
            this.SWbtn.Size = new System.Drawing.Size(118, 54);
            this.SWbtn.TabIndex = 3;
            this.SWbtn.Text = "STAR WARS";
            this.SWbtn.UseVisualStyleBackColor = true;
            this.SWbtn.Click += new System.EventHandler(this.SWbtn_Click);
            // 
            // natgeoBtn
            // 
            this.natgeoBtn.Location = new System.Drawing.Point(509, 105);
            this.natgeoBtn.Name = "natgeoBtn";
            this.natgeoBtn.Size = new System.Drawing.Size(118, 54);
            this.natgeoBtn.TabIndex = 4;
            this.natgeoBtn.Text = "NATIONAL GEOGRAPHIC";
            this.natgeoBtn.UseVisualStyleBackColor = true;
            this.natgeoBtn.Click += new System.EventHandler(this.natgeoBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.natgeoBtn);
            this.Controls.Add(this.SWbtn);
            this.Controls.Add(this.marvelBtn);
            this.Controls.Add(this.pixarBtn);
            this.Controls.Add(this.disneyBtt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button disneyBtt;
        private System.Windows.Forms.Button pixarBtn;
        private System.Windows.Forms.Button marvelBtn;
        private System.Windows.Forms.Button SWbtn;
        private System.Windows.Forms.Button natgeoBtn;
        private System.Windows.Forms.Button button1;
    }
}

