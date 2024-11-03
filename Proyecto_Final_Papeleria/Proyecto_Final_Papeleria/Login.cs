using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Papeleria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        public void errores(int error, Label lbl1)
        {
            switch (error)
            {
                case 0:
                    lbl1.Text = "Solo puedes ingresar, numeros,letras,guiones bajos y puntos.";
                    break;
                case 1:
                    lbl1.Text = "Introduce mínimo 5 caracteres";
                    break;
                case 2:
                    lbl1.Text = "Introduce mínimo 8 caracteres";
                    break;
            }
            lbl1.Show();
        }
        public bool validarn(char c)
        {
            if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57) && c != 95 && c != 46 && c != 164 && c != 165 && c > 31 && c != 127) return false;
            else return true;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (true) //funcion validar si hay usuarios
            {
                timer.Stop();
                lblprimeru.Hide();
                this.Hide();
                iniciarsesion sesion = new iniciarsesion(this);
                sesion.Show();
            }
        }
        private void btncrearu_Click(object sender, EventArgs e)
        {
            lblvalidarc.Hide();
            lblvalidarn.Hide();
            if (txtusuario.Text.Length < 5) errores(1,lblvalidarn);
            if (txtcontrasena.Text.Length < 8) errores(2,lblvalidarc);
            //crear el usuario
        }
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblvalidarn.Hide();
            if(!validarn(e.KeyChar))
            {
                e.Handled = true;
                errores(0, lblvalidarn);
            }
        }
        private void btniniciars_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciarsesion sesion = new iniciarsesion(this);
            sesion.Show();
        }
    }
}
