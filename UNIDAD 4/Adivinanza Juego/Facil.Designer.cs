namespace Adivinanza
{
    partial class fmrFacil
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoFacil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroFacil = new System.Windows.Forms.TextBox();
            this.btnAceptarFacil = new System.Windows.Forms.Button();
            this.btnReiniciarFacil = new System.Windows.Forms.Button();
            this.btnSalirFacil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegiste nivel \"Facil\"";
            // 
            // lblResultadoFacil
            // 
            this.lblResultadoFacil.AutoSize = true;
            this.lblResultadoFacil.Location = new System.Drawing.Point(23, 52);
            this.lblResultadoFacil.Name = "lblResultadoFacil";
            this.lblResultadoFacil.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoFacil.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa numero del 1 al 3";
            // 
            // txtNumeroFacil
            // 
            this.txtNumeroFacil.Location = new System.Drawing.Point(145, 96);
            this.txtNumeroFacil.Name = "txtNumeroFacil";
            this.txtNumeroFacil.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroFacil.TabIndex = 3;
            // 
            // btnAceptarFacil
            // 
            this.btnAceptarFacil.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__1_;
            this.btnAceptarFacil.Location = new System.Drawing.Point(26, 127);
            this.btnAceptarFacil.Name = "btnAceptarFacil";
            this.btnAceptarFacil.Size = new System.Drawing.Size(79, 31);
            this.btnAceptarFacil.TabIndex = 4;
            this.btnAceptarFacil.Text = "Aceptar";
            this.btnAceptarFacil.UseVisualStyleBackColor = true;
            this.btnAceptarFacil.Click += new System.EventHandler(this.btnAceptarFacil_Click);
            // 
            // btnReiniciarFacil
            // 
            this.btnReiniciarFacil.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__1_;
            this.btnReiniciarFacil.Location = new System.Drawing.Point(191, 127);
            this.btnReiniciarFacil.Name = "btnReiniciarFacil";
            this.btnReiniciarFacil.Size = new System.Drawing.Size(79, 31);
            this.btnReiniciarFacil.TabIndex = 5;
            this.btnReiniciarFacil.Text = "Reiniciar";
            this.btnReiniciarFacil.UseVisualStyleBackColor = true;
            this.btnReiniciarFacil.Click += new System.EventHandler(this.btnReiniciarFacil_Click);
            // 
            // btnSalirFacil
            // 
            this.btnSalirFacil.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__3_;
            this.btnSalirFacil.Location = new System.Drawing.Point(253, 256);
            this.btnSalirFacil.Name = "btnSalirFacil";
            this.btnSalirFacil.Size = new System.Drawing.Size(75, 23);
            this.btnSalirFacil.TabIndex = 6;
            this.btnSalirFacil.Text = "Salir";
            this.btnSalirFacil.UseVisualStyleBackColor = true;
            this.btnSalirFacil.Click += new System.EventHandler(this.btnSalirFacil_Click);
            // 
            // fmrFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__2_;
            this.ClientSize = new System.Drawing.Size(340, 291);
            this.Controls.Add(this.btnSalirFacil);
            this.Controls.Add(this.btnReiniciarFacil);
            this.Controls.Add(this.btnAceptarFacil);
            this.Controls.Add(this.txtNumeroFacil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultadoFacil);
            this.Controls.Add(this.label1);
            this.Name = "fmrFacil";
            this.Text = "Facil";
            this.Load += new System.EventHandler(this.Facil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoFacil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroFacil;
        private System.Windows.Forms.Button btnAceptarFacil;
        private System.Windows.Forms.Button btnReiniciarFacil;
        private System.Windows.Forms.Button btnSalirFacil;
    }
}