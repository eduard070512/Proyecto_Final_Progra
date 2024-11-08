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
        private inicio inicio;
        private iniciarsesion sesion;
        public Verificar_Admin(inicio inicio, iniciarsesion sesion)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.sesion = sesion;
        }
        private void pnlverificar_Paint(object sender, PaintEventArgs e)
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
            else if (txtcontrasena.Text.Length < 8) inicio.errores(2, lblvalidarc);
            else
            {
                int id = inicio.iniciars(txtusuario.Text, txtcontrasena.Text);
                if (id != -1) //funcion que valide usuario admin
                {
                    if (inicio.esadmin(id) == 1)
                    {
                        Login login = new Login(inicio);
                        login.StartPosition = FormStartPosition.Manual;
                        login.Location = new Point(this.Location.X-128, this.Location.Y-35);
                        login.lliniciars.Show();
                        login.Chkadmin.Show();
                        login.lblprimeru.Hide();
                        login.Show();
                        inicio.presiono = 0;
                        sesion.Close();
                        this.Close();
                    }
                    else inicio.errores(4, lblvalidarn);
                }
                else inicio.errores(3,lblvalidarn);
            }
        }

        
    }
}
