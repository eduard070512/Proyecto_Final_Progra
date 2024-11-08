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
        public string nombre;
        public menu(int id, inicio inicio, string nombre)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.nombre = nombre;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            inicio.presiono = 1;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inicio.cerrando == 0 && inicio.presiono ==1)
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

        }
    }
}
