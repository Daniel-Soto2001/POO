namespace Adivinanza
{
    partial class fmrMedio
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
            this.lblResultadoMedio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroMedio = new System.Windows.Forms.TextBox();
            this.btnAceptarMedio = new System.Windows.Forms.Button();
            this.btnReiniciarMedio = new System.Windows.Forms.Button();
            this.btnSalirMedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegiste nivel \"Medio\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResultadoMedio
            // 
            this.lblResultadoMedio.AutoSize = true;
            this.lblResultadoMedio.Location = new System.Drawing.Point(13, 53);
            this.lblResultadoMedio.Name = "lblResultadoMedio";
            this.lblResultadoMedio.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoMedio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa numero del 1 al 5";
            // 
            // txtNumeroMedio
            // 
            this.txtNumeroMedio.Location = new System.Drawing.Point(151, 85);
            this.txtNumeroMedio.Name = "txtNumeroMedio";
            this.txtNumeroMedio.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroMedio.TabIndex = 3;
            // 
            // btnAceptarMedio
            // 
            this.btnAceptarMedio.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__1_;
            this.btnAceptarMedio.Location = new System.Drawing.Point(29, 120);
            this.btnAceptarMedio.Name = "btnAceptarMedio";
            this.btnAceptarMedio.Size = new System.Drawing.Size(87, 30);
            this.btnAceptarMedio.TabIndex = 4;
            this.btnAceptarMedio.Text = "Aceptar";
            this.btnAceptarMedio.UseVisualStyleBackColor = true;
            this.btnAceptarMedio.Click += new System.EventHandler(this.btnAceptarMedio_Click);
            // 
            // btnReiniciarMedio
            // 
            this.btnReiniciarMedio.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__1_;
            this.btnReiniciarMedio.Location = new System.Drawing.Point(189, 120);
            this.btnReiniciarMedio.Name = "btnReiniciarMedio";
            this.btnReiniciarMedio.Size = new System.Drawing.Size(89, 29);
            this.btnReiniciarMedio.TabIndex = 5;
            this.btnReiniciarMedio.Text = "Reiniciar";
            this.btnReiniciarMedio.UseVisualStyleBackColor = true;
            this.btnReiniciarMedio.Click += new System.EventHandler(this.btnReiniciarMedio_Click);
            // 
            // btnSalirMedio
            // 
            this.btnSalirMedio.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__3_;
            this.btnSalirMedio.Location = new System.Drawing.Point(264, 252);
            this.btnSalirMedio.Name = "btnSalirMedio";
            this.btnSalirMedio.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMedio.TabIndex = 6;
            this.btnSalirMedio.Text = "Salir";
            this.btnSalirMedio.UseVisualStyleBackColor = true;
            this.btnSalirMedio.Click += new System.EventHandler(this.btnSalirMedio_Click);
            // 
            // fmrMedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__2_;
            this.ClientSize = new System.Drawing.Size(351, 287);
            this.Controls.Add(this.btnSalirMedio);
            this.Controls.Add(this.btnReiniciarMedio);
            this.Controls.Add(this.btnAceptarMedio);
            this.Controls.Add(this.txtNumeroMedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultadoMedio);
            this.Controls.Add(this.label1);
            this.Name = "fmrMedio";
            this.Text = "Medio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoMedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroMedio;
        private System.Windows.Forms.Button btnAceptarMedio;
        private System.Windows.Forms.Button btnReiniciarMedio;
        private System.Windows.Forms.Button btnSalirMedio;
    }
}