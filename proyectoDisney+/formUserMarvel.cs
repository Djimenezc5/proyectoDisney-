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
    public partial class formUserMarvel : Form
    {
        public formUserMarvel()
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

        private void formUserMarvel_Load(object sender, EventArgs e)
        {
            StreamWriter escribirArchivo = new StreamWriter("Marvel.txt", true);
            escribirArchivo.Close();
            string[] lines = File.ReadAllLines("Marvel.txt");

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
