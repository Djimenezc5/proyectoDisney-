using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
