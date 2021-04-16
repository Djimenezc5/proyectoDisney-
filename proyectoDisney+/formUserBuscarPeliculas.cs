using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoDisney_.CargaTLArchivos;


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

            listBox1.Items.Clear(); 
            List<string> listCoincidencias = mandarTexto.LoadingTxt();
            foreach (var dto in listCoincidencias)
            {
                listBox1.Items.Add(dto);
            }

        }
    }
}
