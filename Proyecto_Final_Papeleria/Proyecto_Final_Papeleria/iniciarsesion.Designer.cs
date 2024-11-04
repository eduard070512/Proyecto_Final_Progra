namespace Proyecto_Final_Papeleria
{
    partial class iniciarsesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciarsesion));
            this.pnliniciars = new System.Windows.Forms.Panel();
            this.lblvalidarc = new System.Windows.Forms.Label();
            this.lblvalidarn = new System.Windows.Forms.Label();
            this.btncrearu = new System.Windows.Forms.Button();
            this.btniniciars = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pnliniciars.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnliniciars
            // 
            this.pnliniciars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnliniciars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnliniciars.Controls.Add(this.lblvalidarc);
            this.pnliniciars.Controls.Add(this.lblvalidarn);
            this.pnliniciars.Controls.Add(this.btncrearu);
            this.pnliniciars.Controls.Add(this.btniniciars);
            this.pnliniciars.Controls.Add(this.txtcontrasena);
            this.pnliniciars.Controls.Add(this.lblcontrasena);
            this.pnliniciars.Controls.Add(this.txtusuario);
            this.pnliniciars.Controls.Add(this.lblusuario);
            this.pnliniciars.Controls.Add(this.lbltitulo);
            this.pnliniciars.Location = new System.Drawing.Point(128, 41);
            this.pnliniciars.Margin = new System.Windows.Forms.Padding(2);
            this.pnliniciars.Name = "pnliniciars";
            this.pnliniciars.Size = new System.Drawing.Size(360, 281);
            this.pnliniciars.TabIndex = 0;
            // 
            // lblvalidarc
            // 
            this.lblvalidarc.AutoSize = true;
            this.lblvalidarc.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarc.Location = new System.Drawing.Point(67, 137);
            this.lblvalidarc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarc.Name = "lblvalidarc";
            this.lblvalidarc.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarc.TabIndex = 5;
            // 
            // lblvalidarn
            // 
            this.lblvalidarn.AutoSize = true;
            this.lblvalidarn.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarn.Location = new System.Drawing.Point(67, 79);
            this.lblvalidarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvalidarn.Name = "lblvalidarn";
            this.lblvalidarn.Size = new System.Drawing.Size(0, 13);
            this.lblvalidarn.TabIndex = 2;
            // 
            // btncrearu
            // 
            this.btncrearu.Image = ((System.Drawing.Image)(resources.GetObject("btncrearu.Image")));
            this.btncrearu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrearu.Location = new System.Drawing.Point(69, 228);
            this.btncrearu.Name = "btncrearu";
            this.btncrearu.Size = new System.Drawing.Size(219, 34);
            this.btncrearu.TabIndex = 8;
            this.btncrearu.Text = "CREAR NUEVO USUARIO";
            this.btncrearu.UseVisualStyleBackColor = true;
            this.btncrearu.Click += new System.EventHandler(this.btncrearu_Click);
            // 
            // btniniciars
            // 
            this.btniniciars.Image = ((System.Drawing.Image)(resources.GetObject("btniniciars.Image")));
            this.btniniciars.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btniniciars.Location = new System.Drawing.Point(69, 184);
            this.btniniciars.Margin = new System.Windows.Forms.Padding(2);
            this.btniniciars.Name = "btniniciars";
            this.btniniciars.Size = new System.Drawing.Size(219, 34);
            this.btniniciars.TabIndex = 7;
            this.btniniciars.Text = "INICIAR SESIÓN";
            this.btniniciars.UseVisualStyleBackColor = true;
            this.btniniciars.Click += new System.EventHandler(this.btniniciars_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(70, 152);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(218, 20);
            this.txtcontrasena.TabIndex = 6;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.BackColor = System.Drawing.Color.Transparent;
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
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(218, 20);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Location = new System.Drawing.Point(68, 63);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(191, 13);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "INGRESA EL NOMRBE DE USUARIO";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Silver;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(60, 11);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(257, 40);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "INICIAR SESION";
            // 
            // iniciarsesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnliniciars);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "iniciarsesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iniciarsesion";
            this.pnliniciars.ResumeLayout(false);
            this.pnliniciars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnliniciars;
        private System.Windows.Forms.Button btniniciars;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btncrearu;
        private System.Windows.Forms.Label lblvalidarn;
        private System.Windows.Forms.Label lblvalidarc;
    }
}