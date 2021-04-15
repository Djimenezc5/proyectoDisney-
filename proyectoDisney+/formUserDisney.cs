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

namespace proyectoDisney_
{
    public partial class formUserDisney : Form
    {
        public formUserDisney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUserFeed f1 = new formUserFeed();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formUserBuscarPeliculas buscarPelicula = new formUserBuscarPeliculas();
            this.Hide();
            buscarPelicula.Show();
        }

        private void formUserDisney_Load(object sender, EventArgs e)
        {
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
    }
}
