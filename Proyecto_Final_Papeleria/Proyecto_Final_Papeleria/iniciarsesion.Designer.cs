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
            this.llnuevou = new System.Windows.Forms.LinkLabel();
            this.lblvalidarc = new System.Windows.Forms.Label();
            this.lblvalidarn = new System.Windows.Forms.Label();
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
            this.pnliniciars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnliniciars.Controls.Add(this.llnuevou);
            this.pnliniciars.Controls.Add(this.lblvalidarc);
            this.pnliniciars.Controls.Add(this.lblvalidarn);
            this.pnliniciars.Controls.Add(this.btniniciars);
            this.pnliniciars.Controls.Add(this.txtcontrasena);
            this.pnliniciars.Controls.Add(this.lblcontrasena);
            this.pnliniciars.Controls.Add(this.txtusuario);
            this.pnliniciars.Controls.Add(this.lblusuario);
            this.pnliniciars.Controls.Add(this.lbltitulo);
            this.pnliniciars.Location = new System.Drawing.Point(128, 35);
            this.pnliniciars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnliniciars.Name = "pnliniciars";
            this.pnliniciars.Size = new System.Drawing.Size(451, 350);
            this.pnliniciars.TabIndex = 0;
            // 
            // llnuevou
            // 
            this.llnuevou.BackColor = System.Drawing.Color.Transparent;
            this.llnuevou.Location = new System.Drawing.Point(252, 295);
            this.llnuevou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llnuevou.Name = "llnuevou";
            this.llnuevou.Size = new System.Drawing.Size(169, 15);
            this.llnuevou.TabIndex = 9;
            this.llnuevou.TabStop = true;
            this.llnuevou.Text = "CREAR NUEVO USUARIO";
            this.llnuevou.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llnuevou_LinkClicked);
            // 
            // lblvalidarc
            // 
            this.lblvalidarc.AutoSize = true;
            this.lblvalidarc.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidarc.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarc.Location = new System.Drawing.Point(25, 145);
            this.lblvalidarc.Name = "lblvalidarc";
            this.lblvalidarc.Size = new System.Drawing.Size(0, 16);
            this.lblvalidarc.TabIndex = 5;
            // 
            // lblvalidarn
            // 
            this.lblvalidarn.AutoSize = true;
            this.lblvalidarn.BackColor = System.Drawing.Color.Transparent;
            this.lblvalidarn.ForeColor = System.Drawing.Color.Red;
            this.lblvalidarn.Location = new System.Drawing.Point(24, 79);
            this.lblvalidarn.Name = "lblvalidarn";
            this.lblvalidarn.Size = new System.Drawing.Size(0, 16);
            this.lblvalidarn.TabIndex = 2;
            // 
            // btniniciars
            // 
            this.btniniciars.Image = ((System.Drawing.Image)(resources.GetObject("btniniciars.Image")));
            this.btniniciars.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btniniciars.Location = new System.Drawing.Point(26, 230);
            this.btniniciars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btniniciars.Name = "btniniciars";
            this.btniniciars.Size = new System.Drawing.Size(395, 42);
            this.btniniciars.TabIndex = 7;
            this.btniniciars.Text = "INICIAR SESIÓN";
            this.btniniciars.UseVisualStyleBackColor = true;
            this.btniniciars.Click += new System.EventHandler(this.btniniciars_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(26, 167);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(395, 22);
            this.txtcontrasena.TabIndex = 6;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblcontrasena.Location = new System.Drawing.Point(27, 129);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(183, 16);
            this.lblcontrasena.TabIndex = 4;
            this.lblcontrasena.Text = "INGRESA LA CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(26, 103);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(395, 22);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Location = new System.Drawing.Point(26, 64);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(234, 16);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "INGRESA EL NOMRBE DE USUARIO";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Silver;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(64, 15);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(318, 49);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "INICIAR SESION";
            // 
            // iniciarsesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 424);
            this.Controls.Add(this.pnliniciars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblvalidarn;
        private System.Windows.Forms.Label lblvalidarc;
        private System.Windows.Forms.LinkLabel llnuevou;
    }
}