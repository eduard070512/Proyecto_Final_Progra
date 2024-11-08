﻿using System;
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
        private void Login_Load(object sender, EventArgs e)
        {
            inicio.presiono = 1;
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
            inicio.presiono = 0;
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
                int id;
                if (Chkadmin.Checked) id = inicio.crearusuario(txtusuario.Text, txtcontrasena.Text, 1);
                else id = inicio.crearusuario(txtusuario.Text, txtcontrasena.Text, 0);
                if (id == -1) MessageBox.Show("No se pudo guardar el usuario", "ERROR");
                else
                {
                    inicio.presiono = 0;
                    this.Close();
                    menu menu = new menu(id,inicio,txtusuario.Text);
                    menu.StartPosition = FormStartPosition.Manual;
                    menu.Location = new Point(this.Location.X, this.Location.Y);
                    menu.Show();

                }
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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
