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
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(200, 69);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(509, 96);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "SISTEMA DE VENTAS DE \r\nPAPELERIA MAC BEEPD";
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(306, 206);
            this.btncontinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(243, 55);
            this.btncontinuar.TabIndex = 2;
            this.btncontinuar.Text = "CONTINUAR";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 424);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btncontinuar;
    }
}