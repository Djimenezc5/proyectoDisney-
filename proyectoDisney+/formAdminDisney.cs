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
            //Y si el .txt no existe creara uno.
            StreamWriter archivo = new StreamWriter("Disney.txt", true);
            archivo.Close();

            //Metodo para leer y almecenar en una arregle temporal el contenido de mi .txt
            string[] lines = System.IO.File.ReadAllLines("Disney.txt");

            //Con ayuda del arreglo realizamos la insercion de los datos del arreglo lines
            //A nuestra lista simple
            foreach (string line in lines)
            {
                disney.insertar(line);
            }

            //Leemos nuestra lista simple y sus nodos con el metodo val_nodo y los almacenamos
            //en una arreglo de string unidimencional en donde cada nodo estara separado por un |
            //El cual marcara el fin de mi nodo y al a marcara donde debe de hacer un salto de linea
            string[] list1 = disney.val_nodo().Split('|');
            //Posteriormente lo agregamos al lisbox que poseemos en donde cada nodo sera un Item
            foreach (string item in list1)
            {
                //Nos sirve para descarter el ultimo nodo de mi lista que estre siempre sera nulo
                //Y si lo dejamos representara un posible error al realizar otras acciones
                if (!string.IsNullOrEmpty(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void agregarBtt_Click(object sender, EventArgs e)
        {
            //Capturamos texto de nuestro textbox y lo agregamos como un item a nuestro listbox
            listBox1.Items.Add(t_entradaTbox.Text);
            
            //Inicializamos la escritura de nuestro txt y marcamos nuestro booleano como false
            //para que sobre escriba mi archivo con los datos que le enviamos
            StreamWriter swFile = new StreamWriter("Disney.txt", false);

            //Sobre escribimos con los datos que se enceuntren en mi listBox
            foreach (var fila in listBox1.Items)
            {
                    swFile.WriteLine(fila);
            }
            //Cerramos el archivo
            swFile.Close();
            //Insertamos nuestro dato que se encuentra en el textBox a nuestra lista simple
            disney.insertar(t_entradaTbox.Text);
            t_entradaTbox.Text = "";

        }

        private void eliminarBtt_Click(object sender, EventArgs e)
        {

            //Metodo para eliminar un item cuando nuestro textbox no tiene nada o esta vacio
            if (t_entradaTbox.Text != " ")
            {
                listBox1.Items.Remove(t_entradaTbox.Text);
                //Eliminamos un nodo en nuestra lista simple
                disney.eliminar(listBox1.SelectedItem);
                t_entradaTbox.Text = "";
            }
            //Metodo para eliminar un item cuando nuestro textbox tiene texto
                listBox1.Items.Remove(listBox1.SelectedItem);
                //Eliminamos un nodo en nuestra lista simple
                disney.eliminar(listBox1.SelectedItem);

            //Inicializamos la escritura de nuestro txt y marcamos nuestro booleano como false
            //para que sobre escriba mi archivo con los datos que le enviamos
            StreamWriter swFile = new StreamWriter("Disney.txt", false);
            //Sobre escribimos con los datos que se enceuntren en mi listBox
            foreach (var fila in listBox1.Items)
            {
                swFile.WriteLine(fila);
            }
            //Cerramos el archivo
            swFile.Close();
        }

        private void RegresarBtt_Click(object sender, EventArgs e)
        {
            //Regresamos a nuestro  formulario administrador
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
