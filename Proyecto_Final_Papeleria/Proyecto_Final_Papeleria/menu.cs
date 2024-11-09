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
    public partial class menu : Form
    {
        private inicio inicio;
        private perfil perfil1;
        public string nombre;
        public string usuario;
        public int id;
        public menu(int id, inicio inicio1, string usuario, string nombre)
        {
            InitializeComponent();
            this.inicio = inicio1;
            this.usuario = usuario;
            this.nombre = nombre;
            this.id = id;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            inicio.presiono = 1;
            perfil1 = new perfil();
        }
        public void mostrarcontrol(UserControl control, Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);
            panel.BringToFront();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inicio.cerrando == 0 && inicio.presiono == 1)
            {
                e.Cancel = true;
                cerrar cerrar = new cerrar(inicio);
                cerrar.StartPosition = FormStartPosition.Manual;
                cerrar.Location = new Point(this.Location.X + (this.Width - cerrar.Width) / 2, this.Location.Y + (this.Height - cerrar.Height) / 2);
                cerrar.ShowDialog();
            }
        }

        private void Pbusuario_Click(object sender, EventArgs e)
        {
            perfil1.lblnombre.Text = nombre;
            perfil1.lblusuario.Text = "@" + usuario + "h";
            mostrarcontrol(perfil1, pnlperfil);
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
        }   

        private void pnlperfil_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pnlperfil_Leave(object sender, EventArgs e)
        {
            pnlperfil.Controls.Clear();
            pnlperfil.SendToBack();
        }


        private void menu_Click(object sender, EventArgs e)
        {
        }
    }
}
