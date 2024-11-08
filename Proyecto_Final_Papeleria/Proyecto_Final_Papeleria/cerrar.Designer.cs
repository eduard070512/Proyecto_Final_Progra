namespace Proyecto_Final_Papeleria
{
    partial class cerrar
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
            this.lblconfirmar = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblconfirmar
            // 
            this.lblconfirmar.AutoSize = true;
            this.lblconfirmar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmar.Location = new System.Drawing.Point(12, 20);
            this.lblconfirmar.Name = "lblconfirmar";
            this.lblconfirmar.Size = new System.Drawing.Size(280, 44);
            this.lblconfirmar.TabIndex = 0;
            this.lblconfirmar.Text = "¿ESTAS SEGURO QUE DESEAS \r\nSALIR DE LA APLICACIÓN?";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(76, 68);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(90, 29);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "SI";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(187, 68);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(90, 29);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "NO";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.lblconfirmar);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 120);
            this.panel1.TabIndex = 10;
            // 
            // cerrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(306, 114);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cerrar";
            this.Text = "SALIR DE LA APLICACIÓN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblconfirmar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panel1;
    }
}