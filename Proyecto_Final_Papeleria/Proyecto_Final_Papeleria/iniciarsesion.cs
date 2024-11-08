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
        private void iniciarsesion_Load(object sender, EventArgs e)
        {
            inicio.presiono = 1;
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
                menu menu = new menu(id,inicio,txtusuario.Text);
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = new Point(this.Location.X, this.Location.Y);
                menu.Show();
                inicio.presiono = 0;
                this.Close();
            }
        }
        private void llnuevou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Verificar_Admin verificar = new Verificar_Admin(inicio, this);
            verificar.StartPosition = FormStartPosition.Manual;
            verificar.Location = new Point(this.Location.X + 128, this.Location.Y + 35);
            verificar.ShowDialog();
        }

        private void iniciarsesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inicio.cerrando == 0 && inicio.presiono ==1)
            {
                e.Cancel = true;
                cerrar cerrar = new cerrar(inicio);
                cerrar.StartPosition = FormStartPosition.Manual;
                cerrar.Location = new Point(this.Location.X + 198, this.Location.Y + 142);
                cerrar.ShowDialog();
            }
        }

        
    }
}
