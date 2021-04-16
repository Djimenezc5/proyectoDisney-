namespace proyectoDisney_
{
    partial class formAdminDisney
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_entradaTbox = new System.Windows.Forms.TextBox();
            this.agregarBtt = new System.Windows.Forms.Button();
            this.eliminarBtt = new System.Windows.Forms.Button();
            this.RegresarBtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 342);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peliculas disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar el nombre de la pelicula:";
            // 
            // t_entradaTbox
            // 
            this.t_entradaTbox.Location = new System.Drawing.Point(192, 59);
            this.t_entradaTbox.Name = "t_entradaTbox";
            this.t_entradaTbox.Size = new System.Drawing.Size(250, 20);
            this.t_entradaTbox.TabIndex = 3;
            // 
            // agregarBtt
            // 
            this.agregarBtt.BackColor = System.Drawing.Color.RoyalBlue;
            this.agregarBtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregarBtt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtt.ForeColor = System.Drawing.Color.White;
            this.agregarBtt.Location = new System.Drawing.Point(230, 103);
            this.agregarBtt.Name = "agregarBtt";
            this.agregarBtt.Size = new System.Drawing.Size(75, 59);
            this.agregarBtt.TabIndex = 4;
            this.agregarBtt.Text = "Agregar una pelicula";
            this.agregarBtt.UseVisualStyleBackColor = false;
            this.agregarBtt.Click += new System.EventHandler(this.agregarBtt_Click);
            // 
            // eliminarBtt
            // 
            this.eliminarBtt.BackColor = System.Drawing.Color.RoyalBlue;
            this.eliminarBtt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminarBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtt.ForeColor = System.Drawing.Color.White;
            this.eliminarBtt.Location = new System.Drawing.Point(326, 103);
            this.eliminarBtt.Name = "eliminarBtt";
            this.eliminarBtt.Size = new System.Drawing.Size(75, 59);
            this.eliminarBtt.TabIndex = 5;
            this.eliminarBtt.Text = "Eliminar una pelicula";
            this.eliminarBtt.UseVisualStyleBackColor = false;
            this.eliminarBtt.Click += new System.EventHandler(this.eliminarBtt_Click);
            // 
            // RegresarBtt
            // 
            this.RegresarBtt.BackColor = System.Drawing.Color.RoyalBlue;
            this.RegresarBtt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegresarBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresarBtt.ForeColor = System.Drawing.Color.White;
            this.RegresarBtt.Location = new System.Drawing.Point(382, 347);
            this.RegresarBtt.Name = "RegresarBtt";
            this.RegresarBtt.Size = new System.Drawing.Size(67, 33);
            this.RegresarBtt.TabIndex = 6;
            this.RegresarBtt.Text = "Regresar";
            this.RegresarBtt.UseVisualStyleBackColor = false;
            this.RegresarBtt.Click += new System.EventHandler(this.RegresarBtt_Click);
            // 
            // formAdminDisney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoDisney_.Properties.Resources.backgroundFeed;
            this.ClientSize = new System.Drawing.Size(454, 388);
            this.Controls.Add(this.RegresarBtt);
            this.Controls.Add(this.eliminarBtt);
            this.Controls.Add(this.agregarBtt);
            this.Controls.Add(this.t_entradaTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "formAdminDisney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            this.Load += new System.EventHandler(this.formAdminDisney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_entradaTbox;
        private System.Windows.Forms.Button agregarBtt;
        private System.Windows.Forms.Button eliminarBtt;
        private System.Windows.Forms.Button RegresarBtt;
    }
}