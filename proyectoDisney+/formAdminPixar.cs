using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoDisney_.Metodos_list.Lista_simple;
using System.IO;


namespace proyectoDisney_
{
    public partial class formAdminPixar : Form
    {
        // Creammos una isntacia de la clase
        Lista pixar;

        public formAdminPixar()
        {
            InitializeComponent();
            //Creamos un objeto de tipo lista simple
            pixar = new Lista();

        }

        private void formAdminPixar_Load(object sender, EventArgs e)
        {
            //Metodo para leer el achivo que contiene mi lista de elementos de Disney
            StreamWriter archivo = new StreamWriter("Pixar.txt", true);
            archivo.Close();

            string[] lines = System.IO.File.ReadAllLines("Pixar.txt");

            foreach (string line in lines)
            {
                pixar.insertar(line);
            }

            string[] list1 = pixar.val_nodo().Split('|');

            foreach (string item in list1)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void eliminarBtt_Click(object sender, EventArgs e)
        {
            if (t_entradaTbox.Text != " ")
            {
                listBox1.Items.Remove(t_entradaTbox.Text);
                pixar.eliminar(listBox1.SelectedItem);
                t_entradaTbox.Text = "";

            }

            listBox1.Items.Remove(listBox1.SelectedItem);
            pixar.eliminar(listBox1.SelectedItem);

            StreamWriter swFile = new StreamWriter("Pixar.txt", false);

            foreach (var fila in listBox1.Items)
            {
                swFile.WriteLine(fila);
            }
            swFile.Close();
        }

        private void agregarBtt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(t_entradaTbox.Text);

            StreamWriter swFile = new StreamWriter("Pixar.txt", false);

            foreach (var fila in listBox1.Items)
            {
                swFile.WriteLine(fila);
            }

            swFile.Close();
            pixar.insertar(t_entradaTbox.Text);
            t_entradaTbox.Text = "";
        }

        private void RegresarBtt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
