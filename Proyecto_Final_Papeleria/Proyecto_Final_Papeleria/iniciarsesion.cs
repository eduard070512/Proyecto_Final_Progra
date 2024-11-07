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
        private inicio inicio;
        public iniciarsesion(inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblvalidarn.Hide();
            if (!inicio.validarn(e.KeyChar))
            {
                e.Handled = true;
                inicio.errores(0, lblvalidarn);
            }
        }
        private void btniniciars_Click(object sender, EventArgs e)
        {
            lblvalidarc.Hide();
            lblvalidarn.Hide();
            if (txtusuario.Text.Length < 5) inicio.errores(1, lblvalidarn);
            if (txtcontrasena.Text.Length < 8) inicio.errores(2, lblvalidarc);
            int id = inicio.iniciars(txtusuario.Text, txtcontrasena.Text);
            if (id == -1) inicio.errores(3, lblvalidarn);
            else
            {
                menu menu = new menu(id);
                menu.Show();
            }
        }
        private void llnuevou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Verificar_Admin verificar = new Verificar_Admin(inicio, this);
            verificar.Show();
            this.Enabled = false;
        }
    }
}
