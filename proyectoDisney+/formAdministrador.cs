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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAdminDisney DisneyAdmin = new formAdminDisney();
            this.Hide();
            DisneyAdmin.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            perfilesUsuarios user1 = new perfilesUsuarios();
            this.Hide();
            user1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAdminPixar PixarAdmin = new formAdminPixar();
            this.Hide();
            PixarAdmin.Show();
        }

        private void marvelBtn_Click(object sender, EventArgs e)
        {
            formAdminMarvel MarvelAdmin = new formAdminMarvel();
            this.Hide();
            MarvelAdmin.Show();

        }

        private void SWbtn_Click(object sender, EventArgs e)
        {
            formAdminSW SWAdmin = new formAdminSW();
            this.Hide();
            SWAdmin.Show();
        }

        private void natgeoBtn_Click(object sender, EventArgs e)
        {
            formAdminNatGeo NGAdmin = new formAdminNatGeo();
            this.Hide();
            NGAdmin.Show();
        }
    }
}
