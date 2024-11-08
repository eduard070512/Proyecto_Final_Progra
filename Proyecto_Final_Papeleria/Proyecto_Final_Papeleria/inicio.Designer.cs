namespace Proyecto_Final_Papeleria
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.PBlogo = new System.Windows.Forms.PictureBox();
            this.pnlizq = new System.Windows.Forms.Panel();
            this.pnlfondo = new System.Windows.Forms.Panel();
            this.pnlderecha = new System.Windows.Forms.Panel();
            this.Pbcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).BeginInit();
            this.pnlizq.SuspendLayout();
            this.pnlfondo.SuspendLayout();
            this.pnlderecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(134)))), ((int)(((byte)(171)))));
            this.lbltitulo.Location = new System.Drawing.Point(35, 50);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(247, 211);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "BIENVENIDO AL\r\nSISTEMA DE VENTAS DE \r\nPAPELERIA MAC BEEPD";
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.btncontinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontinuar.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.ForeColor = System.Drawing.Color.White;
            this.btncontinuar.Location = new System.Drawing.Point(42, 291);
            this.btncontinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(243, 55);
            this.btncontinuar.TabIndex = 2;
            this.btncontinuar.Text = "INGRESAR";
            this.btncontinuar.UseVisualStyleBackColor = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // PBlogo
            // 
            this.PBlogo.BackColor = System.Drawing.Color.Transparent;
            this.PBlogo.Image = ((System.Drawing.Image)(resources.GetObject("PBlogo.Image")));
            this.PBlogo.Location = new System.Drawing.Point(-1, 29);
            this.PBlogo.Name = "PBlogo";
            this.PBlogo.Size = new System.Drawing.Size(400, 366);
            this.PBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBlogo.TabIndex = 3;
            this.PBlogo.TabStop = false;
            // 
            // pnlizq
            // 
            this.pnlizq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(171)))));
            this.pnlizq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlizq.Controls.Add(this.PBlogo);
            this.pnlizq.Location = new System.Drawing.Point(3, 3);
            this.pnlizq.Name = "pnlizq";
            this.pnlizq.Size = new System.Drawing.Size(359, 416);
            this.pnlizq.TabIndex = 4;
            // 
            // pnlfondo
            // 
            this.pnlfondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlfondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlfondo.Controls.Add(this.pnlderecha);
            this.pnlfondo.Controls.Add(this.pnlizq);
            this.pnlfondo.Location = new System.Drawing.Point(0, -1);
            this.pnlfondo.Name = "pnlfondo";
            this.pnlfondo.Size = new System.Drawing.Size(703, 426);
            this.pnlfondo.TabIndex = 4;
            // 
            // pnlderecha
            // 
            this.pnlderecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(234)))));
            this.pnlderecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlderecha.Controls.Add(this.Pbcerrar);
            this.pnlderecha.Controls.Add(this.lbltitulo);
            this.pnlderecha.Controls.Add(this.btncontinuar);
            this.pnlderecha.Location = new System.Drawing.Point(361, 3);
            this.pnlderecha.Name = "pnlderecha";
            this.pnlderecha.Size = new System.Drawing.Size(335, 416);
            this.pnlderecha.TabIndex = 5;
            // 
            // Pbcerrar
            // 
            this.Pbcerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Pbcerrar.ErrorImage")));
            this.Pbcerrar.Image = ((System.Drawing.Image)(resources.GetObject("Pbcerrar.Image")));
            this.Pbcerrar.Location = new System.Drawing.Point(291, 3);
            this.Pbcerrar.Name = "Pbcerrar";
            this.Pbcerrar.Size = new System.Drawing.Size(31, 27);
            this.Pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbcerrar.TabIndex = 4;
            this.Pbcerrar.TabStop = false;
            this.Pbcerrar.Click += new System.EventHandler(this.Pbcerrar_Click);
            this.Pbcerrar.MouseEnter += new System.EventHandler(this.Pbcerrar_MouseEnter);
            this.Pbcerrar.MouseLeave += new System.EventHandler(this.Pbcerrar_MouseLeave);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(702, 424);
            this.Controls.Add(this.pnlfondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).EndInit();
            this.pnlizq.ResumeLayout(false);
            this.pnlfondo.ResumeLayout(false);
            this.pnlderecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.PictureBox PBlogo;
        private System.Windows.Forms.Panel pnlizq;
        private System.Windows.Forms.Panel pnlfondo;
        private System.Windows.Forms.Panel pnlderecha;
        private System.Windows.Forms.PictureBox Pbcerrar;
    }
}