using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoDisney_.Metodos_list.Cola;
using proyectoDisney_.Metodos_list.Pila;
using proyectoDisney_.variable_Global;

namespace proyectoDisney_
{

    public partial class formUserFeed : Form
    {
        public formUserFeed()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formUserMarvel formMarvel = new formUserMarvel();
            this.Hide();
            formMarvel.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            formUserDisney fomDisney = new formUserDisney();
            this.Hide();
            fomDisney.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formUserPixar formPix = new formUserPixar();
            this.Hide();
            formPix.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formUserStarWars formStarWars = new formUserStarWars();
            this.Hide();
            formStarWars.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formUserNatGeographic nationGeoForm = new formUserNatGeographic();
            this.Hide();
            nationGeoForm.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            formUserBuscarPeliculas busquedaAvanzada = new formUserBuscarPeliculas();
            this.Hide();
            busquedaAvanzada.Show();
        }

        private int ImgNum = 0;

        private void sigImg()
        {
            if (ImgNum == 16)
            {
                ImgNum = 1;

            }

            //pictureBox1.ImageLocation = string.Format(@"imagenes carrusel\{0}.jpg", ImgNum);
            pictureBox1.ImageLocation = string.Format(@"{0}.jpg", ImgNum);
            ImgNum++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sigImg();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            formUserMiLista f2 = new formUserMiLista();
            this.Hide();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void formUserFeed_Load(object sender, EventArgs e)
        {

        }
    }
    
}
