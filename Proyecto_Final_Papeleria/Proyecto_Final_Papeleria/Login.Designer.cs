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
            this.lblvalidaru = new System.Windows.Forms.Label();
            this.btncrearu = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblprimeru = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblvalidarn = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.pnlregistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlregistro
            // 
            this.pnlregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.pnlregistro.Controls.Add(this.lblvalidarn);
            this.pnlregistro.Controls.Add(this.txtnombre);
            this.pnlregistro.Controls.Add(this.lblnombre);
            this.pnlregistro.Controls.Add(this.Chkadmin);
            this.pnlregistro.Controls.Add(this.lliniciars);
            this.pnlregistro.Controls.Add(this.lblvalidarc);
            this.pnlregistro.Controls.Add(this.lblvalidaru);
            this.pnlregistro.Controls.Add(this.btncrearu);
            this.pnlregistro.Controls.Add(this.txtcontrasena);
            this.pnlregistro.Controls.Add(this.lblcontrasena);
            this.pnlregistro.Controls.Add(this.txtusuario);
            this.pnlregistro.Controls.Add(this.lblusuario);
            this.pnlregistro.Controls.Add(this.lblprimeru);
            this.pnlregistro.Controls.Add(this.lbltitulo);
            this.pnlregistro.Location = new System.Drawing.Point(96, 28);
            this.pnlregistro.Margin = new System.Windows.Forms.Padding(2);
            this.pnlregistro.Name = "pnlregistro";
            this.pnlregistro.Size = new System.Drawing.Size(482, 350);
            this.pnlregistro.TabIndex = 0;
            // 
            // Chkadmin
            // 
            this.Chkadmin.AutoSize = true;
            this.Chkadmin.BackColor = System.Drawing.Color.Transparent;
            this.Chkadmin.Location = new System.Drawing.Point(26, 243);
            this.Chkadmin.Margin = new System.Windows.Forms.Padding(2);
            this.Chkadmin.Name = "Chkadmin";
            this.Chkadmin.Size = new System.Drawing.Size(297, 20);
            this.Chkadmin.TabIndex = 10;
            this.Chkadmin.Text = "SELECCIONA SI EL USUARIO SERA ADMIN";
            this.Chkadmin.UseVisualStyleBackColor = false;
            this.Chkadmin.Visible = false;
            // 
            // lliniciars
            // 
            this.lliniciars.BackColor = System.Drawing.Color.Transparent;
            this.lliniciars.Location = new System.Drawing.Point(305, 309);
            this.lliniciars.Name = "lliniciars";
            this.lliniciars.Size = new System.Drawing.Size(116, 22);
            this.lliniciars.TabIndex = 13;
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
            this.lblvalidarc.Location = new System.Drawing.Point(23, 195);
            this.lblvalidarc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarc.Name = "lblvalidarc";
            this.lblvalidarc.Size = new System.Drawing.Size(0, 16);
            this.lblvalidarc.TabIndex = 8;
            // 
            // lblvalidaru
            // 
            this.lblvalidaru.AutoSize = true;
            this.lblvalidaru.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidaru.ForeColor = System.Drawing.Color.Red;
            this.lblvalidaru.Location = new System.Drawing.Point(23, 74);
            this.lblvalidaru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidaru.Name = "lblvalidaru";
            this.lblvalidaru.Size = new System.Drawing.Size(0, 16);
            this.lblvalidaru.TabIndex = 2;
            // 
            // btncrearu
            // 
            this.btncrearu.Image = ((System.Drawing.Image)(resources.GetObject("btncrearu.Image")));
            this.btncrearu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btncrearu.Location = new System.Drawing.Point(28, 267);
            this.btncrearu.Margin = new System.Windows.Forms.Padding(2);
            this.btncrearu.Name = "btncrearu";
            this.btncrearu.Size = new System.Drawing.Size(395, 40);
            this.btncrearu.TabIndex = 11;
            this.btncrearu.Text = "CREAR USUARIO";
            this.btncrearu.UseVisualStyleBackColor = true;
            this.btncrearu.Click += new System.EventHandler(this.btncrearu_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(26, 216);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(395, 22);
            this.txtcontrasena.TabIndex = 9;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblcontrasena.Location = new System.Drawing.Point(25, 182);
            this.lblcontrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(183, 16);
            this.lblcontrasena.TabIndex = 7;
            this.lblcontrasena.Text = "INGRESA LA CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(26, 97);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(395, 22);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Location = new System.Drawing.Point(25, 59);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(234, 16);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "INGRESA EL NOMRBE DE USUARIO";
            // 
            // lblprimeru
            // 
            this.lblprimeru.AutoSize = true;
            this.lblprimeru.BackColor = System.Drawing.Color.Transparent;
            this.lblprimeru.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblprimeru.Location = new System.Drawing.Point(25, 309);
            this.lblprimeru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprimeru.Name = "lblprimeru";
            this.lblprimeru.Size = new System.Drawing.Size(409, 32);
            this.lblprimeru.TabIndex = 12;
            this.lblprimeru.Text = "NOTA: AUN NO SE HAN REGISTRADO USUARIOS.\r\nEL PRIMER USUARIO REGISTRADO SERA EL AD" +
    "MINISTRADOR\r\n";
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(102, 4);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(281, 45);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "REGISTRATE";
            // 
            // lblvalidarn
            // 
            this.lblvalidarn.AutoSize = true;
            this.lblvalidarn.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidarn.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarn.Location = new System.Drawing.Point(23, 137);
            this.lblvalidarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarn.Name = "lblvalidarn";
            this.lblvalidarn.Size = new System.Drawing.Size(0, 16);
            this.lblvalidarn.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(26, 158);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(395, 22);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Location = new System.Drawing.Point(25, 124);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(151, 16);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "INGRESA TU NOMBRE";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(702, 424);
            this.Controls.Add(this.pnlregistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAPELERIA LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
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
        private System.Windows.Forms.Label lblvalidaru;
        public System.Windows.Forms.LinkLabel lliniciars;
        public System.Windows.Forms.CheckBox Chkadmin;
        public System.Windows.Forms.Label lblprimeru;
        private System.Windows.Forms.Label lblvalidarn;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
    }
}

