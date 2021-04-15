using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoDisney_.variable_Global;

namespace proyectoDisney_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAdminDisney DisneyAdmin = new formAdminDisney();
            this.Hide();
            DisneyAdmin.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            perfilesUsuarios f1 = new perfilesUsuarios();
            f1.Visible = true;

            if (variableGlobal.contador == 5)
            {
                f1.construccion_BotonesTemps();
                f1.construccion_BotonesTemps();
            }
            else if ((variableGlobal.contador == 4))
            {
                f1.construccion_BotonesTemps();
            }

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAdminPixar PixarAdmin = new formAdminPixar();
            this.Hide();
            PixarAdmin.Show();
        }

        private void marvelBtn_Click(object sender, EventArgs e)
        {
            formAdminMarvel MarvelAdmin = new formAdminMarvel();
            this.Hide();
            MarvelAdmin.Show();

        }

        private void SWbtn_Click(object sender, EventArgs e)
        {
            formAdminSW SWAdmin = new formAdminSW();
            this.Hide();
            SWAdmin.Show();
        }

        private void natgeoBtn_Click(object sender, EventArgs e)
        {
            formAdminNatGeo NGAdmin = new formAdminNatGeo();
            this.Hide();
            NGAdmin.Show();
        }
        
        private int ImgNum = 0;

        private void sigImg()
        {
            if (ImgNum == 16)
            {
                ImgNum = 1;
                 
            }

            pictureBox1.ImageLocation = string.Format(@"imagenes carrusel\{0}.jpg", ImgNum);
            ImgNum++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sigImg();
        }
    }
}
