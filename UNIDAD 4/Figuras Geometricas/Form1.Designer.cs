namespace Figuras_Geometricas
{
    partial class frmOriginal
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbxCuadrado = new System.Windows.Forms.CheckBox();
            this.cbxTriangulo = new System.Windows.Forms.CheckBox();
            this.cbxCirculo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxCuadrado
            // 
            this.cbxCuadrado.AutoSize = true;
            this.cbxCuadrado.Location = new System.Drawing.Point(33, 70);
            this.cbxCuadrado.Name = "cbxCuadrado";
            this.cbxCuadrado.Size = new System.Drawing.Size(72, 17);
            this.cbxCuadrado.TabIndex = 1;
            this.cbxCuadrado.Text = "Cuadrado";
            this.cbxCuadrado.UseVisualStyleBackColor = true;
            this.cbxCuadrado.CheckedChanged += new System.EventHandler(this.cbxCuadrado_CheckedChanged);
            // 
            // cbxTriangulo
            // 
            this.cbxTriangulo.AutoSize = true;
            this.cbxTriangulo.Location = new System.Drawing.Point(188, 70);
            this.cbxTriangulo.Name = "cbxTriangulo";
            this.cbxTriangulo.Size = new System.Drawing.Size(70, 17);
            this.cbxTriangulo.TabIndex = 2;
            this.cbxTriangulo.Text = "Trinagulo";
            this.cbxTriangulo.UseVisualStyleBackColor = true;
            // 
            // cbxCirculo
            // 
            this.cbxCirculo.AutoSize = true;
            this.cbxCirculo.Location = new System.Drawing.Point(310, 70);
            this.cbxCirculo.Name = "cbxCirculo";
            this.cbxCirculo.Size = new System.Drawing.Size(58, 17);
            this.cbxCirculo.TabIndex = 3;
            this.cbxCirculo.Text = "Circulo";
            this.cbxCirculo.UseVisualStyleBackColor = true;
            this.cbxCirculo.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Figuras Geometricas";
            // 
            // frmOriginal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCirculo);
            this.Controls.Add(this.cbxTriangulo);
            this.Controls.Add(this.cbxCuadrado);
            this.Controls.Add(this.button1);
            this.Name = "frmOriginal";
            this.Text = "Figura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxCuadrado;
        private System.Windows.Forms.CheckBox cbxTriangulo;
        private System.Windows.Forms.CheckBox cbxCirculo;
        private System.Windows.Forms.Label label1;
    }
}

