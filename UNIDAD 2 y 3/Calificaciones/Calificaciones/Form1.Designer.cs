namespace Calificaciones
{
    partial class frmCalificaciones
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
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.txtContadorCali = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblApro = new System.Windows.Forms.Label();
            this.lblRepro = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.Location = new System.Drawing.Point(126, 29);
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(61, 13);
            this.lblCalificaciones.TabIndex = 0;
            this.lblCalificaciones.Text = "Calificacion";
            this.lblCalificaciones.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContadorCali
            // 
            this.txtContadorCali.Location = new System.Drawing.Point(235, 22);
            this.txtContadorCali.Name = "txtContadorCali";
            this.txtContadorCali.Size = new System.Drawing.Size(165, 20);
            this.txtContadorCali.TabIndex = 1;
            this.txtContadorCali.TextChanged += new System.EventHandler(this.txtContadorCali_TextChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(261, 60);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(109, 35);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(284, 182);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(116, 53);
            this.btnReporte.TabIndex = 6;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblApro
            // 
            this.lblApro.AutoSize = true;
            this.lblApro.Location = new System.Drawing.Point(75, 115);
            this.lblApro.Name = "lblApro";
            this.lblApro.Size = new System.Drawing.Size(58, 13);
            this.lblApro.TabIndex = 7;
            this.lblApro.Text = "Aprobados";
            // 
            // lblRepro
            // 
            this.lblRepro.AutoSize = true;
            this.lblRepro.Location = new System.Drawing.Point(78, 158);
            this.lblRepro.Name = "lblRepro";
            this.lblRepro.Size = new System.Drawing.Size(65, 13);
            this.lblRepro.TabIndex = 8;
            this.lblRepro.Text = "Reprobados";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(81, 198);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(51, 13);
            this.lblPro.TabIndex = 9;
            this.lblPro.Text = "Promedio";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(180, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 262);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.lblRepro);
            this.Controls.Add(this.lblApro);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.txtContadorCali);
            this.Controls.Add(this.lblCalificaciones);
            this.Name = "frmCalificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificaciones;
        private System.Windows.Forms.TextBox txtContadorCali;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblApro;
        private System.Windows.Forms.Label lblRepro;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSalir;
    }
}

