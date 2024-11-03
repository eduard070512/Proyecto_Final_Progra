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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btniniciars = new System.Windows.Forms.Button();
            this.lblvalidarc = new System.Windows.Forms.Label();
            this.lblvalidarn = new System.Windows.Forms.Label();
            this.btncrearu = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblprimeru = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btniniciars);
            this.panel1.Controls.Add(this.lblvalidarc);
            this.panel1.Controls.Add(this.lblvalidarn);
            this.panel1.Controls.Add(this.btncrearu);
            this.panel1.Controls.Add(this.txtcontrasena);
            this.panel1.Controls.Add(this.lblcontrasena);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.lblprimeru);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(128, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 281);
            this.panel1.TabIndex = 0;
            // 
            // btniniciars
            // 
            this.btniniciars.Image = ((System.Drawing.Image)(resources.GetObject("btniniciars.Image")));
            this.btniniciars.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btniniciars.Location = new System.Drawing.Point(69, 228);
            this.btniniciars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btniniciars.Name = "btniniciars";
            this.btniniciars.Size = new System.Drawing.Size(219, 34);
            this.btniniciars.TabIndex = 9;
            this.btniniciars.Text = "INICIAR SESION";
            this.btniniciars.UseVisualStyleBackColor = true;
            this.btniniciars.Visible = false;
            this.btniniciars.Click += new System.EventHandler(this.btniniciars_Click);
            // 
            // lblvalidarc
            // 
            this.lblvalidarc.AutoSize = true;
            this.lblvalidarc.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarc.Location = new System.Drawing.Point(67, 137);
            this.lblvalidarc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarc.Name = "lblvalidarc";
            this.lblvalidarc.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarc.TabIndex = 8;
            // 
            // lblvalidarn
            // 
            this.lblvalidarn.AutoSize = true;
            this.lblvalidarn.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarn.Location = new System.Drawing.Point(67, 79);
            this.lblvalidarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarn.Name = "lblvalidarn";
            this.lblvalidarn.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarn.TabIndex = 7;
            // 
            // btncrearu
            // 
            this.btncrearu.Image = ((System.Drawing.Image)(resources.GetObject("btncrearu.Image")));
            this.btncrearu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btncrearu.Location = new System.Drawing.Point(69, 184);
            this.btncrearu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncrearu.Name = "btncrearu";
            this.btncrearu.Size = new System.Drawing.Size(219, 34);
            this.btncrearu.TabIndex = 6;
            this.btncrearu.Text = "CREAR USUARIO";
            this.btncrearu.UseVisualStyleBackColor = true;
            this.btncrearu.Click += new System.EventHandler(this.btncrearu_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(70, 152);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(218, 20);
            this.txtcontrasena.TabIndex = 5;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(68, 123);
            this.lblcontrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(148, 13);
            this.lblcontrasena.TabIndex = 4;
            this.lblcontrasena.Text = "INGRESA LA CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(70, 93);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(218, 20);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(68, 63);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(191, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "INGRESA EL NOMRBE DE USUARIO";
            // 
            // lblprimeru
            // 
            this.lblprimeru.AutoSize = true;
            this.lblprimeru.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblprimeru.Location = new System.Drawing.Point(40, 236);
            this.lblprimeru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprimeru.Name = "lblprimeru";
            this.lblprimeru.Size = new System.Drawing.Size(333, 26);
            this.lblprimeru.TabIndex = 1;
            this.lblprimeru.Text = "NOTA: AUN NO SE HAN REGISTRADO USUARIOS.\r\nEL PRIMER USUARIO REGISTRADO SERA EL AD" +
    "MINISTRADOR\r\n";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Silver;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(77, 10);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(210, 40);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "REGISTRATE";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAPELERIA LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.Button btncrearu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblprimeru;
        private System.Windows.Forms.Label lblvalidarc;
        private System.Windows.Forms.Label lblvalidarn;
        public System.Windows.Forms.Button btniniciars;
    }
}

