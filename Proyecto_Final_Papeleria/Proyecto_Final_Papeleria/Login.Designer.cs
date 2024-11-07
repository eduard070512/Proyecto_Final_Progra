namespace Proyecto_Final_Papeleria
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlregistro = new System.Windows.Forms.Panel();
            this.Chkadmin = new System.Windows.Forms.CheckBox();
            this.lliniciars = new System.Windows.Forms.LinkLabel();
            this.lblvalidarc = new System.Windows.Forms.Label();
            this.lblvalidarn = new System.Windows.Forms.Label();
            this.btncrearu = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblprimeru = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pnlregistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlregistro
            // 
            this.pnlregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlregistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlregistro.Controls.Add(this.Chkadmin);
            this.pnlregistro.Controls.Add(this.lliniciars);
            this.pnlregistro.Controls.Add(this.lblvalidarc);
            this.pnlregistro.Controls.Add(this.lblvalidarn);
            this.pnlregistro.Controls.Add(this.btncrearu);
            this.pnlregistro.Controls.Add(this.txtcontrasena);
            this.pnlregistro.Controls.Add(this.lblcontrasena);
            this.pnlregistro.Controls.Add(this.txtusuario);
            this.pnlregistro.Controls.Add(this.lblusuario);
            this.pnlregistro.Controls.Add(this.lblprimeru);
            this.pnlregistro.Controls.Add(this.lbltitulo);
            this.pnlregistro.Location = new System.Drawing.Point(128, 35);
            this.pnlregistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlregistro.Name = "pnlregistro";
            this.pnlregistro.Size = new System.Drawing.Size(360, 294);
            this.pnlregistro.TabIndex = 0;
            // 
            // Chkadmin
            // 
            this.Chkadmin.AutoSize = true;
            this.Chkadmin.BackColor = System.Drawing.Color.Transparent;
            this.Chkadmin.Location = new System.Drawing.Point(34, 184);
            this.Chkadmin.Name = "Chkadmin";
            this.Chkadmin.Size = new System.Drawing.Size(244, 17);
            this.Chkadmin.TabIndex = 12;
            this.Chkadmin.Text = "SELECCIONA SI EL USUARIO SERA ADMIN";
            this.Chkadmin.UseVisualStyleBackColor = false;
            this.Chkadmin.Visible = false;
            // 
            // lliniciars
            // 
            this.lliniciars.AutoSize = true;
            this.lliniciars.BackColor = System.Drawing.Color.Transparent;
            this.lliniciars.Location = new System.Drawing.Point(235, 256);
            this.lliniciars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lliniciars.Name = "lliniciars";
            this.lliniciars.Size = new System.Drawing.Size(89, 13);
            this.lliniciars.TabIndex = 11;
            this.lliniciars.TabStop = true;
            this.lliniciars.Text = "INICIAR SESION";
            this.lliniciars.Visible = false;
            this.lliniciars.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lliniciars_LinkClicked);
            // 
            // lblvalidarc
            // 
            this.lblvalidarc.AutoSize = true;
            this.lblvalidarc.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidarc.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarc.Location = new System.Drawing.Point(31, 137);
            this.lblvalidarc.Name = "lblvalidarc";
            this.lblvalidarc.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarc.TabIndex = 5;
            // 
            // lblvalidarn
            // 
            this.lblvalidarn.AutoSize = true;
            this.lblvalidarn.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidarn.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarn.Location = new System.Drawing.Point(31, 73);
            this.lblvalidarn.Name = "lblvalidarn";
            this.lblvalidarn.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarn.TabIndex = 2;
            // 
            // btncrearu
            // 
            this.btncrearu.Image = ((System.Drawing.Image)(resources.GetObject("btncrearu.Image")));
            this.btncrearu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btncrearu.Location = new System.Drawing.Point(34, 206);
            this.btncrearu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrearu.Name = "btncrearu";
            this.btncrearu.Size = new System.Drawing.Size(292, 42);
            this.btncrearu.TabIndex = 7;
            this.btncrearu.Text = "CREAR USUARIO";
            this.btncrearu.UseVisualStyleBackColor = true;
            this.btncrearu.Click += new System.EventHandler(this.btncrearu_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(35, 157);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(289, 20);
            this.txtcontrasena.TabIndex = 6;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblcontrasena.Location = new System.Drawing.Point(33, 121);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(148, 13);
            this.lblcontrasena.TabIndex = 4;
            this.lblcontrasena.Text = "INGRESA LA CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(35, 90);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(289, 20);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Location = new System.Drawing.Point(33, 58);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(191, 13);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "INGRESA EL NOMRBE DE USUARIO";
            // 
            // lblprimeru
            // 
            this.lblprimeru.AutoSize = true;
            this.lblprimeru.BackColor = System.Drawing.Color.Transparent;
            this.lblprimeru.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblprimeru.Location = new System.Drawing.Point(16, 256);
            this.lblprimeru.Name = "lblprimeru";
            this.lblprimeru.Size = new System.Drawing.Size(333, 26);
            this.lblprimeru.TabIndex = 9;
            this.lblprimeru.Text = "NOTA: AUN NO SE HAN REGISTRADO USUARIOS.\r\nEL PRIMER USUARIO REGISTRADO SERA EL AD" +
    "MINISTRADOR\r\n";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Silver;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(75, 11);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(210, 40);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "REGISTRATE";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnlregistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAPELERIA LOGIN";
            this.pnlregistro.ResumeLayout(false);
            this.pnlregistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlregistro;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.Button btncrearu;
        private System.Windows.Forms.Label lblvalidarc;
        private System.Windows.Forms.Label lblvalidarn;
        public System.Windows.Forms.LinkLabel lliniciars;
        public System.Windows.Forms.CheckBox Chkadmin;
        public System.Windows.Forms.Label lblprimeru;
    }
}

