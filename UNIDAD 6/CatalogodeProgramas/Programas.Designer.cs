namespace CatalogodeProgramas
{
    partial class FrmProgramas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramas));
            this.btnUnidad1 = new System.Windows.Forms.Button();
            this.btnUnidad2y3 = new System.Windows.Forms.Button();
            this.btnUnidad4 = new System.Windows.Forms.Button();
            this.btnUnidad5 = new System.Windows.Forms.Button();
            this.btnUnidad6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnidad1
            // 
            this.btnUnidad1.BackColor = System.Drawing.Color.Transparent;
            this.btnUnidad1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnidad1.BackgroundImage")));
            this.btnUnidad1.ImageKey = "(none)";
            this.btnUnidad1.Location = new System.Drawing.Point(22, 51);
            this.btnUnidad1.Name = "btnUnidad1";
            this.btnUnidad1.Size = new System.Drawing.Size(83, 36);
            this.btnUnidad1.TabIndex = 0;
            this.btnUnidad1.Text = "Unidad 1";
            this.btnUnidad1.UseVisualStyleBackColor = false;
            this.btnUnidad1.Click += new System.EventHandler(this.btnUnidad1_Click);
            // 
            // btnUnidad2y3
            // 
            this.btnUnidad2y3.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.boton;
            this.btnUnidad2y3.Location = new System.Drawing.Point(167, 51);
            this.btnUnidad2y3.Name = "btnUnidad2y3";
            this.btnUnidad2y3.Size = new System.Drawing.Size(83, 36);
            this.btnUnidad2y3.TabIndex = 1;
            this.btnUnidad2y3.Text = "Unidad 2 y 3";
            this.btnUnidad2y3.UseVisualStyleBackColor = true;
            this.btnUnidad2y3.Click += new System.EventHandler(this.btnUnidad2y3_Click);
            // 
            // btnUnidad4
            // 
            this.btnUnidad4.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.boton;
            this.btnUnidad4.Location = new System.Drawing.Point(18, 111);
            this.btnUnidad4.Name = "btnUnidad4";
            this.btnUnidad4.Size = new System.Drawing.Size(87, 36);
            this.btnUnidad4.TabIndex = 2;
            this.btnUnidad4.Text = "Unidad 4";
            this.btnUnidad4.UseVisualStyleBackColor = true;
            this.btnUnidad4.Click += new System.EventHandler(this.btnUnidad4_Click);
            // 
            // btnUnidad5
            // 
            this.btnUnidad5.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.boton;
            this.btnUnidad5.Location = new System.Drawing.Point(167, 111);
            this.btnUnidad5.Name = "btnUnidad5";
            this.btnUnidad5.Size = new System.Drawing.Size(83, 36);
            this.btnUnidad5.TabIndex = 3;
            this.btnUnidad5.Text = "Unidad 5";
            this.btnUnidad5.UseVisualStyleBackColor = true;
            this.btnUnidad5.Click += new System.EventHandler(this.btnUnidad5_Click);
            // 
            // btnUnidad6
            // 
            this.btnUnidad6.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.boton;
            this.btnUnidad6.Location = new System.Drawing.Point(18, 170);
            this.btnUnidad6.Name = "btnUnidad6";
            this.btnUnidad6.Size = new System.Drawing.Size(87, 36);
            this.btnUnidad6.TabIndex = 4;
            this.btnUnidad6.Text = "Unidad 6";
            this.btnUnidad6.UseVisualStyleBackColor = true;
            this.btnUnidad6.Click += new System.EventHandler(this.btnUnidad6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidades de Programas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.uno;
            this.button1.Location = new System.Drawing.Point(220, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProgramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalogodeProgramas.Properties.Resources.POO;
            this.ClientSize = new System.Drawing.Size(307, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnidad6);
            this.Controls.Add(this.btnUnidad5);
            this.Controls.Add(this.btnUnidad4);
            this.Controls.Add(this.btnUnidad2y3);
            this.Controls.Add(this.btnUnidad1);
            this.Name = "FrmProgramas";
            this.Text = "Programas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnidad1;
        private System.Windows.Forms.Button btnUnidad2y3;
        private System.Windows.Forms.Button btnUnidad4;
        private System.Windows.Forms.Button btnUnidad5;
        private System.Windows.Forms.Button btnUnidad6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

