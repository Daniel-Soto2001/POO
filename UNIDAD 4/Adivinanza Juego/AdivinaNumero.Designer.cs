namespace Adivinanza
{
    partial class fmrAdivinaNumero
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
            this.ckbFacil = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbMedio = new System.Windows.Forms.CheckBox();
            this.ckbDificil = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbFacil
            // 
            this.ckbFacil.AutoSize = true;
            this.ckbFacil.BackColor = System.Drawing.Color.Transparent;
            this.ckbFacil.Location = new System.Drawing.Point(17, 106);
            this.ckbFacil.Name = "ckbFacil";
            this.ckbFacil.Size = new System.Drawing.Size(48, 17);
            this.ckbFacil.TabIndex = 0;
            this.ckbFacil.Text = "Facil";
            this.ckbFacil.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige el nivel de dificultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "BIENVENIDO AL JUEGO";
            // 
            // ckbMedio
            // 
            this.ckbMedio.AutoSize = true;
            this.ckbMedio.BackColor = System.Drawing.Color.Transparent;
            this.ckbMedio.Location = new System.Drawing.Point(125, 106);
            this.ckbMedio.Name = "ckbMedio";
            this.ckbMedio.Size = new System.Drawing.Size(55, 17);
            this.ckbMedio.TabIndex = 3;
            this.ckbMedio.Text = "Medio";
            this.ckbMedio.UseVisualStyleBackColor = false;
            // 
            // ckbDificil
            // 
            this.ckbDificil.AutoSize = true;
            this.ckbDificil.BackColor = System.Drawing.Color.Transparent;
            this.ckbDificil.Location = new System.Drawing.Point(233, 106);
            this.ckbDificil.Name = "ckbDificil";
            this.ckbDificil.Size = new System.Drawing.Size(51, 17);
            this.ckbDificil.TabIndex = 4;
            this.ckbDificil.Text = "Dificil";
            this.ckbDificil.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__1_;
            this.btnAceptar.Location = new System.Drawing.Point(125, 160);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // fmrAdivinaNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adivinanza.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(329, 289);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.ckbDificil);
            this.Controls.Add(this.ckbMedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbFacil);
            this.Name = "fmrAdivinaNumero";
            this.Text = "Adivina el Numero";
            this.Load += new System.EventHandler(this.fmrAdivinaNumero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbFacil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbMedio;
        private System.Windows.Forms.CheckBox ckbDificil;
        private System.Windows.Forms.Button btnAceptar;
    }
}

