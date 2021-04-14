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

namespace proyectoDisney_
{
    public partial class formUser1 : Form
    {
        //Se crea instancia de pila mi lista usuario
        Pila miLista;
        Cola continuarViendo;
        public formUser1()
        {
            InitializeComponent();
            //Se crea objeto tipo Pila
            miLista = new Pila();
            continuarViendo = new Cola();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marvelForm formMarvel = new marvelForm();
            this.Hide();
            formMarvel.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            perfilesUsuarios f1 = new perfilesUsuarios();
            this.Hide();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter("miListaUser1.txt", true);
            archivo.WriteLine(textBox1.Text);
            archivo.Close();

            miLista.insertar(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter("contViendoUser1.txt", true);
            archivo.WriteLine(textBox2.Text);
            archivo.Close();

            continuarViendo.insertar(textBox2.Text);
            listBox2.Items.Add(textBox2.Text);
        }
        private void formUser1_Load(object sender, EventArgs e)
        {

            //Se busca archivo que contendra la data de mi lista del usuario
            StreamWriter archivoLista = new StreamWriter("miListaUser1.txt", true);
            archivoLista.Close();

            StreamReader leeListar = new StreamReader("miListaUser1.txt");
            //string[] contentMiListaTxt = leeListar.ReadToEnd();
            string[] contentMiListaTxt = File.ReadAllLines("miListaUser1.txt");
            leeListar.Close();

            //Se busca archivo que contendra la data de Continuar viendo del usuario
            StreamWriter archivoContent1 = new StreamWriter("contViendoUser1.txt", true);
            archivoContent1.Close();

            StreamReader archivoLeerUser1 = new StreamReader("contViendoUser1.txt");
            //string dataContinuarViendoTxt = archivoLeerUser1.ReadToEnd();
            string[] dataContinuarViendoTxt = File.ReadAllLines("contViendoUser1.txt");
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
            //
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
            DisneyForm fomDisney = new DisneyForm();
            this.Hide();
            fomDisney.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pixarForm formPix = new pixarForm();
            this.Hide();
            formPix.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StarWarsForm formStarWars = new StarWarsForm();
            this.Hide();
            formStarWars.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nationalGeographicForm nationGeoForm = new nationalGeographicForm();
            this.Hide();
            nationGeoForm.Show();
        }
    }
}
