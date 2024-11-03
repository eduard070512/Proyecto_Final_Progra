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
    public partial class Verificar_Admin : Form
    {
        private Login login;
        private iniciarsesion sesion;
        public Verificar_Admin(Login login, iniciarsesion sesion)
        {
            InitializeComponent();
            this.login = login;
            this.sesion = sesion;
        }
        private void btniniciars_Click(object sender, EventArgs e)
        {
            lblvalidarc.Hide();
            lblvalidarn.Hide();
            if (txtusuario.Text.Length < 5) login.errores(1, lblvalidarn);
            if (txtcontrasena.Text.Length < 8) login.errores(2, lblvalidarc);
            if(true) //funcion que valide usuario admin
            {
                this.Close();
                login.Show();
                login.btniniciars.Show();
                sesion.Close();
            }
        }
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblvalidarn.Hide();
            if (!login.validarn(e.KeyChar))
            {
                e.Handled = true;
                login.errores(0, lblvalidarn);
            }
        }
    }
}
