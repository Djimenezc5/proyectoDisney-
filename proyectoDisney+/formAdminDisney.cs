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
    public partial class formAdminDisney : Form
    {
        // Creammos una isntacia de la clase
        Lista disney;

        public formAdminDisney()
        {
            InitializeComponent();
            //Creamos un objeto de tipo lista simple
            disney = new Lista();
        }

        private void formAdminDisney_Load(object sender, EventArgs e)
        {
            //Metodo para leer el achivo que contiene mi lista de elementos de Disney
            string[] lines = System.IO.File.ReadAllLines("Disney.txt");

            foreach (string line in lines)
            {
                disney.insertar(line);
            }

            string[] list1 = disney.val_nodo().Split('|');

            foreach (string item in list1)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    listBox1.Items.Add(item);
                }
            }
               
        }

        private void agregarBtt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(t_entradaTbox.Text);
            
            StreamWriter swFile = new StreamWriter("Disney.txt", false);

            foreach (var fila in listBox1.Items)
            {
                    swFile.WriteLine(fila);
            }

            swFile.Close();
            disney.insertar(t_entradaTbox.Text);
            t_entradaTbox.Text = "";

        }

        private void eliminarBtt_Click(object sender, EventArgs e)
        {

            
            if (t_entradaTbox.Text != " ")
            {
                listBox1.Items.Remove(t_entradaTbox.Text);
                disney.eliminar(listBox1.SelectedItem);
                t_entradaTbox.Text = "";

            }

                listBox1.Items.Remove(listBox1.SelectedItem);
                disney.eliminar(listBox1.SelectedItem);

            StreamWriter swFile = new StreamWriter("Disney.txt", false);

            foreach (var fila in listBox1.Items)
            {
                swFile.WriteLine(fila);
            }
            swFile.Close();
        }
    }
}
