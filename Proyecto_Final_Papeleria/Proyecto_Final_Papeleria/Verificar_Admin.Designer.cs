﻿namespace Proyecto_Final_Papeleria
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
            this.pnlverificar = new System.Windows.Forms.Panel();
            this.lblverificar = new System.Windows.Forms.Label();
            this.lblvalidarc = new System.Windows.Forms.Label();
            this.lblvalidarn = new System.Windows.Forms.Label();
            this.btniniciars = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pnlverificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlverificar
            // 
            this.pnlverificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlverificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlverificar.Controls.Add(this.lblverificar);
            this.pnlverificar.Controls.Add(this.lblvalidarc);
            this.pnlverificar.Controls.Add(this.lblvalidarn);
            this.pnlverificar.Controls.Add(this.btniniciars);
            this.pnlverificar.Controls.Add(this.txtcontrasena);
            this.pnlverificar.Controls.Add(this.lblcontrasena);
            this.pnlverificar.Controls.Add(this.txtusuario);
            this.pnlverificar.Controls.Add(this.lblusuario);
            this.pnlverificar.Controls.Add(this.lbltitulo);
            this.pnlverificar.Location = new System.Drawing.Point(-2, -2);
            this.pnlverificar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlverificar.Name = "pnlverificar";
            this.pnlverificar.Size = new System.Drawing.Size(360, 281);
            this.pnlverificar.TabIndex = 0;
            // 
            // lblverificar
            // 
            this.lblverificar.AutoSize = true;
            this.lblverificar.BackColor = System.Drawing.Color.Transparent;
            this.lblverificar.Location = new System.Drawing.Point(68, 53);
            this.lblverificar.Name = "lblverificar";
            this.lblverificar.Size = new System.Drawing.Size(261, 52);
            this.lblverificar.TabIndex = 1;
            this.lblverificar.Text = "Para crear un nuevo usuario deberas verificar que\r\ntienes los permisos para crear" +
    "lo iniciando sesion \r\ncomo administrador.\r\nNOTA: El administrador es el primer u" +
    "suario agregado.";
            // 
            // lblvalidarc
            // 
            this.lblvalidarc.AutoSize = true;
            this.lblvalidarc.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidarc.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarc.Location = new System.Drawing.Point(67, 186);
            this.lblvalidarc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarc.Name = "lblvalidarc";
            this.lblvalidarc.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarc.TabIndex = 6;
            // 
            // lblvalidarn
            // 
            this.lblvalidarn.AutoSize = true;
            this.lblvalidarn.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidarn.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarn.Location = new System.Drawing.Point(67, 128);
            this.lblvalidarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarn.Name = "lblvalidarn";
            this.lblvalidarn.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarn.TabIndex = 3;
            // 
            // btniniciars
            // 
            this.btniniciars.Image = ((System.Drawing.Image)(resources.GetObject("btniniciars.Image")));
            this.btniniciars.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btniniciars.Location = new System.Drawing.Point(69, 233);
            this.btniniciars.Margin = new System.Windows.Forms.Padding(2);
            this.btniniciars.Name = "btniniciars";
            this.btniniciars.Size = new System.Drawing.Size(219, 34);
            this.btniniciars.TabIndex = 8;
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
            this.txtcontrasena.TabIndex = 7;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblcontrasena.Location = new System.Drawing.Point(68, 172);
            this.lblcontrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(266, 13);
            this.lblcontrasena.TabIndex = 5;
            this.lblcontrasena.Text = "INGRESA LA CONTRASEÑA DEL ADMINISTRADOR\r\n";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(70, 142);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(218, 20);
            this.txtusuario.TabIndex = 4;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Location = new System.Drawing.Point(68, 112);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(239, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "INGRESA EL NOMRBE DEL ADMINISTRADOR\r\n";
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
            // Verificar_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 273);
            this.Controls.Add(this.pnlverificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Verificar_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar_Admin";
            this.pnlverificar.ResumeLayout(false);
            this.pnlverificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlverificar;
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