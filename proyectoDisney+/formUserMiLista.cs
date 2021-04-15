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
    public partial class formUserMiLista : Form
    {
        //Se crea instancia de pila mi lista usuario
        Pila miLista;
        Cola continuarViendo;
        public formUserMiLista()
        {
            InitializeComponent();
            //Se crea objeto tipo Pila
            miLista = new Pila();
            continuarViendo = new Cola();
        }

        private void formUserMiLista_Load(object sender, EventArgs e)
        {
            cargarArchivosTxt();
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
        private void button1_Click(object sender, EventArgs e)
        {
            string user = variableGlobal.valor;
            StreamWriter archivoLista = new StreamWriter(string.Format("miLista{0}.txt", user), true);
            archivoLista.WriteLine(textBox1.Text);
            archivoLista.Close();


            miLista.insertar(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = variableGlobal.valor;
            StreamWriter archivoContViendo = new StreamWriter(string.Format("contVie{0}.txt", user), true);
            archivoContViendo.WriteLine(textBox2.Text);
            archivoContViendo.Close();

            continuarViendo.insertar(textBox2.Text);
            listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formUserFeed f1 = new formUserFeed();
            this.Hide();
            f1.Show();
        }
    }
}
