namespace Proyecto_Final_Papeleria
{
    partial class perfil
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfil));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.llnombre = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lleditaru = new System.Windows.Forms.LinkLabel();
            this.llagregaru = new System.Windows.Forms.LinkLabel();
            this.lleliminaru = new System.Windows.Forms.LinkLabel();
            this.lblcambiaru = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // llnombre
            // 
            this.llnombre.AutoSize = true;
            this.llnombre.Location = new System.Drawing.Point(79, 56);
            this.llnombre.Name = "llnombre";
            this.llnombre.Size = new System.Drawing.Size(0, 16);
            this.llnombre.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(85, 55);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 16);
            this.lblnombre.TabIndex = 9;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(86, 75);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(0, 16);
            this.lblusuario.TabIndex = 10;
            // 
            // lleditaru
            // 
            this.lleditaru.AutoSize = true;
            this.lleditaru.Location = new System.Drawing.Point(31, 118);
            this.lleditaru.Name = "lleditaru";
            this.lleditaru.Size = new System.Drawing.Size(121, 16);
            this.lleditaru.TabIndex = 11;
            this.lleditaru.TabStop = true;
            this.lleditaru.Text = "EDITAR USUARIO\r\n";
            // 
            // llagregaru
            // 
            this.llagregaru.AutoSize = true;
            this.llagregaru.Location = new System.Drawing.Point(31, 162);
            this.llagregaru.Name = "llagregaru";
            this.llagregaru.Size = new System.Drawing.Size(138, 16);
            this.llagregaru.TabIndex = 12;
            this.llagregaru.TabStop = true;
            this.llagregaru.Text = "AGREGAR USUARIO";
            // 
            // lleliminaru
            // 
            this.lleliminaru.AutoSize = true;
            this.lleliminaru.Location = new System.Drawing.Point(31, 210);
            this.lleliminaru.Name = "lleliminaru";
            this.lleliminaru.Size = new System.Drawing.Size(133, 16);
            this.lleliminaru.TabIndex = 13;
            this.lleliminaru.TabStop = true;
            this.lleliminaru.Text = "ELIMINAR USUARIO";
            // 
            // lblcambiaru
            // 
            this.lblcambiaru.AutoSize = true;
            this.lblcambiaru.Location = new System.Drawing.Point(31, 258);
            this.lblcambiaru.Name = "lblcambiaru";
            this.lblcambiaru.Size = new System.Drawing.Size(153, 16);
            this.lblcambiaru.TabIndex = 14;
            this.lblcambiaru.TabStop = true;
            this.lblcambiaru.Text = "CAMBIAR DE USUARIO";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(31, 302);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CERRAR SESION";
            // 
            // perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(135)))), ((int)(((byte)(173)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblcambiaru);
            this.Controls.Add(this.lleliminaru);
            this.Controls.Add(this.llagregaru);
            this.Controls.Add(this.lleditaru);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llnombre);
            this.Controls.Add(this.pictureBox2);
            this.Name = "perfil";
            this.Size = new System.Drawing.Size(198, 422);
            this.Load += new System.EventHandler(this.perfil_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.perfil_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel llnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lleditaru;
        private System.Windows.Forms.LinkLabel llagregaru;
        private System.Windows.Forms.LinkLabel lleliminaru;
        private System.Windows.Forms.LinkLabel lblcambiaru;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label lblnombre;
        public System.Windows.Forms.Label lblusuario;
    }
}
