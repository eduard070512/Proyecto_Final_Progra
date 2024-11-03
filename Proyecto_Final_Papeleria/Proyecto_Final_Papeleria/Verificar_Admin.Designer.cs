namespace Proyecto_Final_Papeleria
{
    partial class Verificar_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verificar_Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblvalidarc = new System.Windows.Forms.Label();
            this.lblvalidarn = new System.Windows.Forms.Label();
            this.btniniciars = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblverificar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblverificar);
            this.panel1.Controls.Add(this.lblvalidarc);
            this.panel1.Controls.Add(this.lblvalidarn);
            this.panel1.Controls.Add(this.btniniciars);
            this.panel1.Controls.Add(this.txtcontrasena);
            this.panel1.Controls.Add(this.lblcontrasena);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 281);
            this.panel1.TabIndex = 2;
            // 
            // lblvalidarc
            // 
            this.lblvalidarc.AutoSize = true;
            this.lblvalidarc.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarc.Location = new System.Drawing.Point(67, 186);
            this.lblvalidarc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarc.Name = "lblvalidarc";
            this.lblvalidarc.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarc.TabIndex = 10;
            // 
            // lblvalidarn
            // 
            this.lblvalidarn.AutoSize = true;
            this.lblvalidarn.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarn.Location = new System.Drawing.Point(67, 128);
            this.lblvalidarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarn.Name = "lblvalidarn";
            this.lblvalidarn.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarn.TabIndex = 9;
            // 
            // btniniciars
            // 
            this.btniniciars.Image = ((System.Drawing.Image)(resources.GetObject("btniniciars.Image")));
            this.btniniciars.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btniniciars.Location = new System.Drawing.Point(69, 233);
            this.btniniciars.Margin = new System.Windows.Forms.Padding(2);
            this.btniniciars.Name = "btniniciars";
            this.btniniciars.Size = new System.Drawing.Size(219, 34);
            this.btniniciars.TabIndex = 6;
            this.btniniciars.Text = "INICIAR SESIÓN";
            this.btniniciars.UseVisualStyleBackColor = true;
            this.btniniciars.Click += new System.EventHandler(this.btniniciars_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(70, 201);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(218, 20);
            this.txtcontrasena.TabIndex = 5;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(68, 172);
            this.lblcontrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(260, 13);
            this.lblcontrasena.TabIndex = 4;
            this.lblcontrasena.Text = "INGRESA LA CONTRASEÑA DE ADMINISTRADOR\r\n";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(70, 142);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(218, 20);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(68, 112);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(233, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "INGRESA EL NOMRBE DE ADMINISTRADOR\r\n";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Silver;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(2, 9);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(348, 40);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "NECESITAS PERMISOS";
            // 
            // lblverificar
            // 
            this.lblverificar.AutoSize = true;
            this.lblverificar.Location = new System.Drawing.Point(68, 53);
            this.lblverificar.Name = "lblverificar";
            this.lblverificar.Size = new System.Drawing.Size(261, 52);
            this.lblverificar.TabIndex = 11;
            this.lblverificar.Text = "Para crear un nuevo usuario deberas verificar que\r\ntienes los permisos para crear" +
    "lo iniciando sesion \r\ncomo administrador.\r\nNOTA: El administrador es el primer u" +
    "suario agregado.";
            // 
            // Verificar_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 273);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Verificar_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar_Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblvalidarc;
        private System.Windows.Forms.Label lblvalidarn;
        private System.Windows.Forms.Button btniniciars;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblverificar;
    }
}