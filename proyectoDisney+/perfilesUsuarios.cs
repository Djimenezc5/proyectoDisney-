using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoDisney_.Botones;
using proyectoDisney_.variable_Global;


namespace proyectoDisney_
{
    public partial class perfilesUsuarios : Form
    {
        public int y = 230;
        public int x = 236;
        public int conteo = 3;
        
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
            formUsers("user1");
            this.Visible = false;
        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {
            formUsers("user2");
            this.Visible= false;
        }
        public void formUsers(string opcionUsuario)
        {
            variableGlobal.valor = opcionUsuario;
            formUserFeed user1 = new formUserFeed();
            user1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            construccion_BotonesTemps();
        }
        //Funcion que creara y dibujara los botones temporales de los usuarios
        public  void construccion_BotonesTemps()
        {
            
            if (conteo < 5)
            {
                //creacion del boton temporal circular en memoria..
                    BotonCircular temp = new BotonCircular();
                    temp.Height = 144;
                    temp.Width = 144;
                    temp.Location = new Point(x, y);
                    x += 170;
                    temp.Name = string.Format("botonCircular{0}", conteo);
                    temp.Text = string.Format("Usuario {0}", conteo);

                    //Adicionamos el handler
                    temp.Click += new EventHandler(handlerComun_Click);

                    //Adicionamos el boton a la forma
                    Controls.Add(temp);
                    conteo++;
                variableGlobal.contador = conteo;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más usuarios ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void handlerComun_Click(object sender, EventArgs e)
        {
            Console.Beep(((Button)sender).Location.Y * 10, 100);

            formUsers(string.Format("user{0}", conteo));
            this.Visible = false;
        }

    }
}
