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
using Newtonsoft.Json;
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
            StreamWriter archivoLista = new StreamWriter(string.Format("miLista{0}.txt", user),true);
            archivoLista.Close();

            StreamReader leeListar = new StreamReader(string.Format("miLista{0}.txt", user));
            string[] contentMiListaTxt = File.ReadAllLines(string.Format("miLista{0}.txt", user));
            leeListar.Close();

            //Se busca archivo que contendra la data de Continuar viendo del usuario 
            StreamWriter archivoContent1 = new StreamWriter(string.Format("contVie{0}.txt", user), true);
            archivoContent1.Close();

            StreamReader archivoLeerUser1 = new StreamReader(string.Format("contVie{0}.txt", user));
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

        private void button2_Click(object sender, EventArgs e)
        {
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formUserFeed f1 = new formUserFeed();
            this.Hide();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Extrayendo el primer elemento de "Mi Lista" 
            string user = variableGlobal.valor;
            string search_Text = JsonConvert.SerializeObject(miLista.cimaPila()).Replace('"', ' ').Trim();

            StreamWriter archivoContViendo = new StreamWriter(string.Format("contVie{0}.txt", user), true);
            archivoContViendo.WriteLine(search_Text);
            archivoContViendo.Close();

            using (StreamWriter archivoUser = new StreamWriter("temp.txt"))
            {
                using (StreamReader fileRead =  new StreamReader(string.Format("miLista{0}.txt", user)))
                {d
                    string line;

                    while ((line = fileRead.ReadLine())!= null)
                    {
                        if (!line.Contains(search_Text))
                        {
                            archivoUser.WriteLine(line);
                        }
                    }
                }
            }
            File.Delete(string.Format("miLista{0}.txt", user));
            File.Move("temp.txt", string.Format("miLista{0}.txt", user));
            //Insertando en Cola "Continuar viendo"
            continuarViendo.insertar(miLista.cimaPila());
            listBox2.Items.Add(miLista.cimaPila());
            miLista.quitalPila();
            listBox1.Items.Clear();
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox2.DrawMode = DrawMode.Normal;
        }
    }
}
