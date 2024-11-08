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
        public menu(int id, inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
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
                cerrar.Location = new Point(this.Location.X + 198, this.Location.Y + 142);
                cerrar.ShowDialog();
            }
        }
    }
}
