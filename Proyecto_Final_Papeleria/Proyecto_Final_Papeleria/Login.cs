using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_Final_Papeleria
{
    public partial class Login : Form
    {
        private inicio inicio;
        public Login(inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblvalidarn.Hide();
            if(!inicio.validarn(e.KeyChar))
            {
                e.Handled = true;
                inicio.errores(0, lblvalidarn);
            }
        }
        private void lliniciars_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            iniciarsesion sesion = new iniciarsesion(inicio);
            sesion.StartPosition = FormStartPosition.Manual;
            sesion.Location = new Point(this.Location.X, this.Location.Y);
            sesion.Show();
            lblvalidarc.Hide();
            lblvalidarn.Hide();
            this.Close();
        }
        private void btncrearu_Click(object sender, EventArgs e)
        {
            lblvalidarc.Hide();
            lblvalidarn.Hide();
            if (txtusuario.Text.Length < 5) inicio.errores(1, lblvalidarn);
            else if (txtcontrasena.Text.Length < 8) inicio.errores(2, lblvalidarc);
            else
            {
                if (Chkadmin.Checked) inicio.admin = 1;
                int id = inicio.crearusuario(txtusuario.Text, txtcontrasena.Text, inicio.admin);
                if (id == -1) MessageBox.Show("No se pudo guardar el usuario", "ERROR");
                else
                {
                    this.Close();
                    menu menu = new menu(id);
                    menu.StartPosition = FormStartPosition.Manual;
                    menu.Location = new Point(this.Location.X, this.Location.Y);
                    menu.Show();

                }
            }
        }
    }
}
