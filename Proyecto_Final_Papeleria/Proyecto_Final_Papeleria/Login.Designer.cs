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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblprimeru = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btncrearu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btncrearu);
            this.panel1.Controls.Add(this.txtcontrasena);
            this.panel1.Controls.Add(this.lblcontrasena);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.lblprimeru);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(170, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 345);
            this.panel1.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Silver;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(109, 22);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(260, 49);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "REGISTRATE";
            // 
            // lblprimeru
            // 
            this.lblprimeru.AutoSize = true;
            this.lblprimeru.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblprimeru.Location = new System.Drawing.Point(35, 83);
            this.lblprimeru.Name = "lblprimeru";
            this.lblprimeru.Size = new System.Drawing.Size(409, 32);
            this.lblprimeru.TabIndex = 1;
            this.lblprimeru.Text = "AUN NO SE HAN REGISTRADO USUARIOS \r\nEL PRIMER USUARIO REGISTRADO SERA EL ADMINIST" +
    "RADOR\r\n";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(91, 131);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(234, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "INGRESA EL NOMRBE DE USUARIO";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(94, 163);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(290, 22);
            this.txtusuario.TabIndex = 3;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(91, 206);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(183, 16);
            this.lblcontrasena.TabIndex = 4;
            this.lblcontrasena.Text = "INGRESA LA CONTRASEÑA";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(94, 237);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(290, 22);
            this.txtcontrasena.TabIndex = 5;
            // 
            // btncrearu
            // 
            this.btncrearu.Enabled = false;
            this.btncrearu.Image = ((System.Drawing.Image)(resources.GetObject("btncrearu.Image")));
            this.btncrearu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btncrearu.Location = new System.Drawing.Point(94, 278);
            this.btncrearu.Name = "btncrearu";
            this.btncrearu.Size = new System.Drawing.Size(290, 42);
            this.btncrearu.TabIndex = 6;
            this.btncrearu.Text = "CREAR USUARIO";
            this.btncrearu.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAPELERIA LOGIN";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblprimeru;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.Button btncrearu;
    }
}

