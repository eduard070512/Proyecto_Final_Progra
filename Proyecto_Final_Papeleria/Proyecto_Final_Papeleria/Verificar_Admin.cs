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
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblvalidarn.Hide();
            if (!login.validarn(e.KeyChar))
            {
                e.Handled = true;
                login.errores(0, lblvalidarn);
            }
        }
        private void btniniciars_Click(object sender, EventArgs e)
        {
            lblvalidarc.Hide();
            lblvalidarn.Hide();
            if (txtusuario.Text.Length < 5) login.errores(1, lblvalidarn);
            else if (txtcontrasena.Text.Length < 8) login.errores(2, lblvalidarc);
            else
            {
                int id = login.iniciars(txtusuario.Text, txtcontrasena.Text);
                if (id != -1) //funcion que valide usuario admin
                {
                    if (login.esadmin(id) == 1)
                    {
                        this.Close();
                        login.Show();
                        login.lliniciars.Show();
                        sesion.Close();
                    }
                    else login.errores(4, lblvalidarn);
                }
                else login.errores(3,lblvalidarn);
            }
        }
    }
}
