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
    public partial class iniciarsesion : Form
    {
        private Login login;
        public iniciarsesion(Login login)
        {
            InitializeComponent();
            this.login = login;
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
            if (txtcontrasena.Text.Length < 8) login.errores(2, lblvalidarc);
            int id = login.iniciars(txtusuario.Text, txtcontrasena.Text);
            if (id == -1) login.errores(3, lblvalidarn);
            else
            {
                menu menu = new menu(id);
                menu.Show();
            }
        }
        private void llnuevou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Verificar_Admin verificar = new Verificar_Admin(login, this);
            verificar.Show();
            this.Enabled = false;
        }
    }
}
