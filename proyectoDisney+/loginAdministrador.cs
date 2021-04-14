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
    public partial class loginAdministrador : Form
    {
        public loginAdministrador()
        {
            InitializeComponent();
        }

        private void loginAdministrador_Load(object sender, EventArgs e)
        {

        }
        string userAdmin = "Admin";
        string userPassword= "123";
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUserLogin.Text;
            string password = txtPassword.Text;

            if (user.Equals(userAdmin) && password.Equals(userPassword))
            {
                //Login exitoso
                txtPassword.Clear();
                txtPassword.Clear();

                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                txtPassword.Clear();
                txtPassword.Clear();
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perfilesUsuarios user1 = new perfilesUsuarios();
            this.Hide();
            user1.Show();
        }
    }
}
