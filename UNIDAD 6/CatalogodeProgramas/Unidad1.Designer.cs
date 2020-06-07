namespace CatalogodeProgramas
{
    partial class fmrUnidad1
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnMiPrimerProyectoWindowsForms1 = new System.Windows.Forms.Button();
            this.btnProyecto1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.nou;
            this.btnRegresar.Location = new System.Drawing.Point(12, 248);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(76, 32);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnMiPrimerProyectoWindowsForms1
            // 
            this.btnMiPrimerProyectoWindowsForms1.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.uno;
            this.btnMiPrimerProyectoWindowsForms1.Location = new System.Drawing.Point(12, 67);
            this.btnMiPrimerProyectoWindowsForms1.Name = "btnMiPrimerProyectoWindowsForms1";
            this.btnMiPrimerProyectoWindowsForms1.Size = new System.Drawing.Size(280, 50);
            this.btnMiPrimerProyectoWindowsForms1.TabIndex = 1;
            this.btnMiPrimerProyectoWindowsForms1.Text = "MiPrimerProyectoWindowsForms1";
            this.btnMiPrimerProyectoWindowsForms1.UseVisualStyleBackColor = true;
            this.btnMiPrimerProyectoWindowsForms1.Click += new System.EventHandler(this.btnMiPrimerProyectoWindowsForms1_Click);
            // 
            // btnProyecto1
            // 
            this.btnProyecto1.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.uno;
            this.btnProyecto1.Location = new System.Drawing.Point(12, 142);
            this.btnProyecto1.Name = "btnProyecto1";
            this.btnProyecto1.Size = new System.Drawing.Size(280, 44);
            this.btnProyecto1.TabIndex = 2;
            this.btnProyecto1.Text = "Proyecto 1";
            this.btnProyecto1.UseVisualStyleBackColor = true;
            this.btnProyecto1.Click += new System.EventHandler(this.btnProyecto1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Programas Unidad 1";
            // 
            // fmrUnidad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.rojo;
            this.ClientSize = new System.Drawing.Size(345, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProyecto1);
            this.Controls.Add(this.btnMiPrimerProyectoWindowsForms1);
            this.Controls.Add(this.btnRegresar);
            this.Name = "fmrUnidad1";
            this.Text = "Unidad1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnMiPrimerProyectoWindowsForms1;
        private System.Windows.Forms.Button btnProyecto1;
        private System.Windows.Forms.Label label1;
    }
}