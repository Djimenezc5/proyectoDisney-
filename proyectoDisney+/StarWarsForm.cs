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
    public partial class StarWarsForm : Form
    {
        public StarWarsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUser1 f1 = new formUser1();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarPeliculasForm buscarPelicula = new buscarPeliculasForm();
            this.Hide();
            buscarPelicula.Show();
        }
    }
}
