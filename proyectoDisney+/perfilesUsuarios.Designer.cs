
namespace proyectoDisney_
{
    partial class perfilesUsuarios
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.botonCircular2 = new proyectoDisney_.Botones.BotonCircular();
            this.botonCircular1 = new proyectoDisney_.Botones.BotonCircular();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Verdana", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(27, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Verdana", 10F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(667, 413);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "Administrador";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::proyectoDisney_.Properties.Resources.agregarUsuario;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(693, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 55);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonCircular2
            // 
            this.botonCircular2.BackColor = System.Drawing.Color.Transparent;
            this.botonCircular2.Location = new System.Drawing.Point(402, 83);
            this.botonCircular2.Name = "botonCircular2";
            this.botonCircular2.Size = new System.Drawing.Size(151, 143);
            this.botonCircular2.TabIndex = 7;
            this.botonCircular2.Text = "Usuario 2";
            this.botonCircular2.UseVisualStyleBackColor = false;
            this.botonCircular2.Click += new System.EventHandler(this.botonCircular2_Click);
            // 
            // botonCircular1
            // 
            this.botonCircular1.BackColor = System.Drawing.Color.Transparent;
            this.botonCircular1.ForeColor = System.Drawing.Color.Black;
            this.botonCircular1.Location = new System.Drawing.Point(234, 85);
            this.botonCircular1.Name = "botonCircular1";
            this.botonCircular1.Size = new System.Drawing.Size(144, 139);
            this.botonCircular1.TabIndex = 6;
            this.botonCircular1.Text = "Usuario 1";
            this.botonCircular1.UseVisualStyleBackColor = false;
            this.botonCircular1.Click += new System.EventHandler(this.botonCircular1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(678, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agregar Usuarios";
            // 
            // perfilesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoDisney_.Properties.Resources.backgroundFeed1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonCircular2);
            this.Controls.Add(this.botonCircular1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Name = "perfilesUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "perfilesUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private Botones.BotonCircular botonCircular1;
        private Botones.BotonCircular botonCircular2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}