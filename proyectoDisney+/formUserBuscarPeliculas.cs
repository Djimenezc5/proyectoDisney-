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
using proyectoDisney_.CargaTLArchivos;
using proyectoDisney_.variable_Global;

namespace proyectoDisney_
{
    public partial class formUserBuscarPeliculas : Form
    {
        public formUserBuscarPeliculas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Falta validar para que sea dinamico y se pueda reutilizar en los demas perfiles usuarios
            formUserFeed f1 = new formUserFeed();
            this.Hide();
            f1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargaArchivos mandarTexto = new cargaArchivos();
            string value = textBox1.Text;
            listBox1.Items.Clear(); 
            List<string> listCoincidencias = mandarTexto.LoadingTxt(value);
            foreach (var dto in listCoincidencias)
            {
                listBox1.Items.Add(dto);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Metodo para escribir en el archivo del usuario
            string dato = Convert.ToString(listBox1.SelectedItem);
            string user = variableGlobal.valor;
            StreamWriter archivoUser = new StreamWriter(string.Format("miLista{0}.txt", user), true);
            archivoUser.WriteLine(dato);
            archivoUser.Close();
            MessageBox.Show("Se agrego el contenido " + "*" + dato + "*" + " a MI LISTA de reproducción.");
        }
    }
}
