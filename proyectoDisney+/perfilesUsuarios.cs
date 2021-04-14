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

        private void button1_Click(object sender, EventArgs e)
        {
            formUser1 user1 = new formUser1();
            this.Hide();
            user1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loginAdministrador loginAdmin = new loginAdministrador();
            this.Hide();
            loginAdmin.Show();
        }
    }
}
