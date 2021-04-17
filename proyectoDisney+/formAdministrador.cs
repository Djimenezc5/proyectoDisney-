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
            //Metodo el cual nos servira para poder abrir el formulario formAdminDisney
            formAdminDisney DisneyAdmin = new formAdminDisney();
            this.Hide();
            DisneyAdmin.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Metodo el cual nos servira para poder abrir el formulario perfilesUsuarios
            perfilesUsuarios f1 = new perfilesUsuarios();
            
            //El siguiente metodo nos sirve para saber ni nuestros botones temporares
            //Estan activados o desactivados
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
            //Metodo el cual nos servira para poder abrir el formulario formAdminPixar
            formAdminPixar PixarAdmin = new formAdminPixar();
            this.Hide();
            PixarAdmin.Show();
        }

        private void marvelBtn_Click(object sender, EventArgs e)
        {
            //Metodo el cual nos servira para poder abrir el formulario formAdminMarvel
            formAdminMarvel MarvelAdmin = new formAdminMarvel();
            this.Hide();
            MarvelAdmin.Show();

        }

        private void SWbtn_Click(object sender, EventArgs e)
        {
            //Metodo el cual nos servira para poder abrir el formulario formAdminSW 
            formAdminSW SWAdmin = new formAdminSW();
            this.Hide();
            SWAdmin.Show();
        }

        private void natgeoBtn_Click(object sender, EventArgs e)
        {
            //Metodo el cual nos servira para poder abrir el formulario formAdminNatGeo
            formAdminNatGeo NGAdmin = new formAdminNatGeo();
            this.Hide();
            NGAdmin.Show();
        }
        

        //Variable la cual utilizaremos como contador para nuestro timer
        private int ImgNum = 0;


        private void sigImg()
        {
        //Metodo que cumple la funcion de nuestro carrusel de imagenes
        // Con el siguiente metodo indicamos que al llegar nuestra variable a un valor de
        // 16 el ImgNum volvera a ser 0
            if (ImgNum == 16)
            {
                ImgNum = 1;
                 
            }
            //Hacemos la busqueda en la carpeta que se enceuntra en el bin\debug\imagenes carrusel
            //Y las mostramos en nuestro pictureBox1
            pictureBox1.ImageLocation = string.Format(@"imagenes carrusel\{0}.jpg", ImgNum);
            //Sumamos una unidad a ImgNum (ImgNum+1)
            ImgNum++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Llamada al metodo sigImg() 
            sigImg();
        }
    }
}
