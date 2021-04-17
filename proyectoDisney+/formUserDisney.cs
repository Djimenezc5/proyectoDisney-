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
using proyectoDisney_.variable_Global;
using System.IO;

namespace proyectoDisney_
{
    /// <summary>
    /// Formulario Disney
    /// </summary>
    public partial class formUserDisney : Form
    {
        public formUserDisney()
        {
            InitializeComponent();
        }
        //Regresara al Feed
        private void button1_Click(object sender, EventArgs e)
        {
            formUserFeed f1 = new formUserFeed();
            this.Hide();
            f1.Show();
        }
        //Se movera al form de buscar pelicula
        private void button2_Click(object sender, EventArgs e)
        {
            formUserBuscarPeliculas buscarPelicula = new formUserBuscarPeliculas();
            this.Hide();
            buscarPelicula.Show();
        }
        /// <summary>
        /// Funcion que cargara el txt sobre la categoria Disney
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formUserDisney_Load(object sender, EventArgs e)
        {
            cargarArchivosTxt();
            StreamWriter escribirArchivo = new StreamWriter("Disney.txt", true);
            escribirArchivo.Close();
            string[] lines = File.ReadAllLines("Disney.txt");

            foreach (string fila in lines)
            {
                if (!string.IsNullOrEmpty(fila))
                {
                    listBox1.Items.Add(fila);
                }
            }
        }

        /// <summary>
        /// Cargara el archivo txt dinamico y lo leera
        /// </summary>
        public void cargarArchivosTxt()
        {
            string user = variableGlobal.valor;
            //Se busca archivo que contendra la data de mi lista del usuario
            StreamWriter archivoLista = new StreamWriter(string.Format("miLista{0}.txt", user), true);
            archivoLista.Close();

            StreamReader leeListar = new StreamReader(string.Format("miLista{0}.txt", user), true);
            string[] contentMiListaTxt = File.ReadAllLines(string.Format("miLista{0}.txt", user));
            leeListar.Close();        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Metodo para escribir en el archivo del usuario
            string dato = Convert.ToString(listBox1.SelectedItem);
            string user = variableGlobal.valor;
            StreamWriter archivoUser = new StreamWriter(string.Format("miLista{0}.txt", user), true);
            archivoUser.WriteLine(dato);
            archivoUser.Close();
            MessageBox.Show("Se agrego el contenido "+"*"+ dato +"*"+ " a MI LISTA de reproducción.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
