﻿using System;
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
            formAdminDisney v2 = new formAdminDisney();
            this.Hide();
            v2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            perfilesUsuarios user1 = new perfilesUsuarios();
            this.Hide();
            user1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
