using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Papeleria
{
    public partial class inicio : Form
    {
        public string cadena_conexion;
        OleDbConnection conn;
        public int admin;
        public inicio()
        {
            InitializeComponent();
        }
        private void inicio_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + @" Data Source = ../../../../BASE/DB_Proyecto_Final_Programacion1.accdb;" + @"Persist Security Info = False");
        }
        public void errores(int error, Label lbl1)
        {
            switch (error)
            {
                case 0:
                    lbl1.Text = "Solo puedes ingresar, numeros,letras,guiones bajos y puntos.";
                    break;
                case 1:
                    lbl1.Text = "Introduce mínimo 5 caracteres";
                    break;
                case 2:
                    lbl1.Text = "Introduce mínimo 8 caracteres";
                    break;
                case 3:
                    lbl1.Text = "El usuario o contraseña no coinciden";
                    break;
                case 4:
                    lbl1.Text = "EL USUARIO INGRESADO NO TIENE PERMISOS DE ADMINISTRADOR";
                    break;
                case 5:
                    lbl1.Text = "";
                    break;
            }
            lbl1.Show();
        }
        public bool validarn(char c)
        {
            if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57) && c != 95 && c != 46 && c != 164 && c != 165 && c > 31 && c != 127) return false;
            else return true;
        }
        public int iniciars(string usuario, string clave)
        {
            string consulta = "SELECT Id FROM USUARIOS WHERE NOMBRE = @usuario AND CONTRASENA = @clave";
            OleDbCommand iniciars = new OleDbCommand(consulta, conn);
            iniciars.Parameters.AddWithValue("@usuario", usuario);
            iniciars.Parameters.AddWithValue("@clave", clave);
            conn.Open();
            object readerid = iniciars.ExecuteScalar();
            conn.Close();
            if (readerid != null)
            {
                return Convert.ToInt32(readerid);
            }
            else
            {
                return -1;
            }
        }
        public int crearusuario(string usuario, string clave, int tipo)
        {
            string consulta = "INSERT INTO USUARIOS (NOMBRE, CONTRASENA, TIPO) VALUES (@usuario, @clave, @tipo)";
            OleDbCommand crearusuario = new OleDbCommand(consulta, conn);
            crearusuario.Parameters.AddWithValue("@usuario", usuario);
            crearusuario.Parameters.AddWithValue("@clave", clave);
            crearusuario.Parameters.AddWithValue("@tipo", tipo);
            conn.Open();
            if (crearusuario.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return 1;
            }
            else
            {
                conn.Close();
                return -1;
            }
        }
        public int esadmin(int id)
        {
            string consulta = "SELECT TIPO FROM USUARIOS WHERE Id = @id";
            OleDbCommand esadmin = new OleDbCommand(consulta, conn);
            esadmin.Parameters.AddWithValue("@id", id);
            conn.Open();
            object resultado = esadmin.ExecuteScalar();
            conn.Close();
            if (resultado != null)
            {
                return Convert.ToInt32(resultado);
            }
            else return -1;
        }
        public int hayusuarios()
        {
            string consulta = "SELECT COUNT(*) FROM USUARIOS";
            OleDbCommand contar = new OleDbCommand(consulta, conn);
            conn.Open();
            int cant = (int)contar.ExecuteScalar();
            conn.Close();
            if (cant > 0) return 1;
            else return 0;
        }
        private void btncontinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            int hay = hayusuarios();
            if (hay == 1) //funcion validar si hay usuarios x
            {
                admin = 0;
                
                MessageBox.Show("h");
                iniciarsesion sesion = new iniciarsesion(this);
                sesion.Show();
            }
            else
            {
                Login login = new Login(this);
                admin = 1;
                login.Show();
            }
        }
    }
}
