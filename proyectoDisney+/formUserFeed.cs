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
        //Se crea instancia de pila mi lista usuario
        Pila miLista;
        Cola continuarViendo;
        public formUserFeed()
        {
            InitializeComponent();
            //Se crea objeto tipo Pila
            miLista = new Pila();
            continuarViendo = new Cola();
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

        private void button7_Click(object sender, EventArgs e)
        {
            string user = variableGlobal.valor;
            StreamWriter archivoLista = new StreamWriter(string.Format("miLista{0}.txt", user), true);
            archivoLista.WriteLine(textBox1.Text);
            archivoLista.Close();


            miLista.insertar(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            string user = variableGlobal.valor;
            StreamWriter archivoContViendo = new StreamWriter(string.Format("contVie{0}.txt", user), true);
            archivoContViendo.WriteLine(textBox2.Text);
            archivoContViendo.Close();

            continuarViendo.insertar(textBox2.Text);
            listBox2.Items.Add(textBox2.Text);
        }
        private void formUser1_Load(object sender, EventArgs e)
        {

            cargarArchivosTxt();
          
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
        public void cargarArchivosTxt()
        {

            string user = variableGlobal.valor;
            //Se busca archivo que contendra la data de mi lista del usuario
            StreamWriter archivoLista = new StreamWriter(string.Format("miLista{0}.txt", user), true);
            archivoLista.Close();

            StreamReader leeListar = new StreamReader(string.Format("miLista{0}.txt", user), true);
            string[] contentMiListaTxt = File.ReadAllLines(string.Format("miLista{0}.txt", user));
            leeListar.Close();

            //Se busca archivo que contendra la data de Continuar viendo del usuario 
            StreamWriter archivoContent1 = new StreamWriter(string.Format("contVie{0}.txt", user), true);
            archivoContent1.Close();

            StreamReader archivoLeerUser1 = new StreamReader(string.Format("contVie{0}.txt", user), true);
            string[] dataContinuarViendoTxt = File.ReadAllLines(string.Format("contVie{0}.txt", user));
            archivoLeerUser1.Close();

            //Insertando en la pila Mi lista el contenido del TXT
            foreach (string line in contentMiListaTxt)
            {
                miLista.insertar(line);
            }

            //Llenando visualmente la Pila mi Lista
            foreach (string value in contentMiListaTxt)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    listBox1.Items.Add(value);
                }
            }
            //Insertando en la cola Continuar viendo del TXT
            foreach (string line in dataContinuarViendoTxt)
            {
                continuarViendo.insertar(line);
            }
            //Llenando visualmente la Cola continuar viendo

            foreach (string item in dataContinuarViendoTxt)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    listBox2.Items.Add(item);
                }
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            formUserBuscarPeliculas busquedaAvanzada = new formUserBuscarPeliculas();
            this.Hide();
            busquedaAvanzada.Show();
        }
    }
    
}
