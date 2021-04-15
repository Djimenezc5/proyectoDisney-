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
    public partial class perfilesUsuarios : Form
    {
        public perfilesUsuarios()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formLoginAdministrador loginAdmin = new formLoginAdministrador();
            this.Hide();
            loginAdmin.Show();
        }

        private void botonCircular1_Click(object sender, EventArgs e)
        {

            formUserFeed user1 = new formUserFeed();
            this.Hide();
            user1.Show();

        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {
            formUserFeed user1 = new formUserFeed();
            this.Hide();
            user1.Show();
        }
    }
}
