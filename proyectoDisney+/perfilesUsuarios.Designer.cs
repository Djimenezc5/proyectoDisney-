﻿
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
            this.botonCircular4 = new proyectoDisney_.Botones.BotonCircular();
            this.botonCircular3 = new proyectoDisney_.Botones.BotonCircular();
            this.botonCircular2 = new proyectoDisney_.Botones.BotonCircular();
            this.botonCircular1 = new proyectoDisney_.Botones.BotonCircular();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(689, 411);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 26);
            this.button6.TabIndex = 5;
            this.button6.Text = "Administrador";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // botonCircular4
            // 
            this.botonCircular4.BackColor = System.Drawing.Color.Transparent;
            this.botonCircular4.Location = new System.Drawing.Point(567, 139);
            this.botonCircular4.Name = "botonCircular4";
            this.botonCircular4.Size = new System.Drawing.Size(151, 143);
            this.botonCircular4.TabIndex = 9;
            this.botonCircular4.Text = "Usuario 4";
            this.botonCircular4.UseVisualStyleBackColor = false;
            // 
            // botonCircular3
            // 
            this.botonCircular3.BackColor = System.Drawing.Color.Transparent;
            this.botonCircular3.Location = new System.Drawing.Point(396, 139);
            this.botonCircular3.Name = "botonCircular3";
            this.botonCircular3.Size = new System.Drawing.Size(151, 143);
            this.botonCircular3.TabIndex = 8;
            this.botonCircular3.Text = "Usuario 3";
            this.botonCircular3.UseVisualStyleBackColor = false;
            // 
            // botonCircular2
            // 
            this.botonCircular2.BackColor = System.Drawing.Color.Transparent;
            this.botonCircular2.Location = new System.Drawing.Point(228, 139);
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
            this.botonCircular1.Location = new System.Drawing.Point(78, 143);
            this.botonCircular1.Name = "botonCircular1";
            this.botonCircular1.Size = new System.Drawing.Size(144, 139);
            this.botonCircular1.TabIndex = 6;
            this.botonCircular1.Text = "Usuario 1";
            this.botonCircular1.UseVisualStyleBackColor = false;
            this.botonCircular1.Click += new System.EventHandler(this.botonCircular1_Click);
            // 
            // perfilesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 467);
            this.Controls.Add(this.botonCircular4);
            this.Controls.Add(this.botonCircular3);
            this.Controls.Add(this.botonCircular2);
            this.Controls.Add(this.botonCircular1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Name = "perfilesUsuarios";
            this.Text = "perfilesUsuarios";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private Botones.BotonCircular botonCircular1;
        private Botones.BotonCircular botonCircular2;
        private Botones.BotonCircular botonCircular3;
        private Botones.BotonCircular botonCircular4;
    }
}