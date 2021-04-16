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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            perfilesUsuarios f1 = new perfilesUsuarios();
            this.Hide();
            f1.Visible = true;
            timer1.Stop();
        }
    }
}
