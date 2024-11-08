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
    public partial class cerrar : Form
    {
        private inicio inicio = new inicio();
        public cerrar(inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            inicio.cerrando = 1;
            Application.Exit();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
