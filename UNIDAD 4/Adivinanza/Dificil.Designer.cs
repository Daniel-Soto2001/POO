namespace Adivinanza
{
    partial class fmrDificil
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
            this.lblResultadoDificil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroDificil = new System.Windows.Forms.TextBox();
            this.btnAceptarDificil = new System.Windows.Forms.Button();
            this.btnReiniciiarDificil = new System.Windows.Forms.Button();
            this.btnSalirDificil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegiste nivel \"Dificil\"";
            // 
            // lblResultadoDificil
            // 
            this.lblResultadoDificil.AutoSize = true;
            this.lblResultadoDificil.Location = new System.Drawing.Point(13, 52);
            this.lblResultadoDificil.Name = "lblResultadoDificil";
            this.lblResultadoDificil.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoDificil.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa numero del 1 al 10";
            // 
            // txtNumeroDificil
            // 
            this.txtNumeroDificil.Location = new System.Drawing.Point(150, 78);
            this.txtNumeroDificil.Name = "txtNumeroDificil";
            this.txtNumeroDificil.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDificil.TabIndex = 3;
            // 
            // btnAceptarDificil
            // 
            this.btnAceptarDificil.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__1_;
            this.btnAceptarDificil.Location = new System.Drawing.Point(16, 122);
            this.btnAceptarDificil.Name = "btnAceptarDificil";
            this.btnAceptarDificil.Size = new System.Drawing.Size(92, 33);
            this.btnAceptarDificil.TabIndex = 4;
            this.btnAceptarDificil.Text = "Aceptar";
            this.btnAceptarDificil.UseVisualStyleBackColor = true;
            this.btnAceptarDificil.Click += new System.EventHandler(this.btnAceptarDificil_Click);
            // 
            // btnReiniciiarDificil
            // 
            this.btnReiniciiarDificil.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__1_;
            this.btnReiniciiarDificil.Location = new System.Drawing.Point(177, 122);
            this.btnReiniciiarDificil.Name = "btnReiniciiarDificil";
            this.btnReiniciiarDificil.Size = new System.Drawing.Size(85, 32);
            this.btnReiniciiarDificil.TabIndex = 5;
            this.btnReiniciiarDificil.Text = "Reiniciar";
            this.btnReiniciiarDificil.UseVisualStyleBackColor = true;
            this.btnReiniciiarDificil.Click += new System.EventHandler(this.btnReiniciiarDificil_Click);
            // 
            // btnSalirDificil
            // 
            this.btnSalirDificil.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__3_;
            this.btnSalirDificil.Location = new System.Drawing.Point(206, 238);
            this.btnSalirDificil.Name = "btnSalirDificil";
            this.btnSalirDificil.Size = new System.Drawing.Size(75, 23);
            this.btnSalirDificil.TabIndex = 6;
            this.btnSalirDificil.Text = "Salir";
            this.btnSalirDificil.UseVisualStyleBackColor = true;
            this.btnSalirDificil.Click += new System.EventHandler(this.btnSalirDificil_Click);
            // 
            // fmrDificil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adivinanza.Properties.Resources.descarga__2_;
            this.ClientSize = new System.Drawing.Size(293, 273);
            this.Controls.Add(this.btnSalirDificil);
            this.Controls.Add(this.btnReiniciiarDificil);
            this.Controls.Add(this.btnAceptarDificil);
            this.Controls.Add(this.txtNumeroDificil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultadoDificil);
            this.Controls.Add(this.label1);
            this.Name = "fmrDificil";
            this.Text = "Dificil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoDificil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroDificil;
        private System.Windows.Forms.Button btnAceptarDificil;
        private System.Windows.Forms.Button btnReiniciiarDificil;
        private System.Windows.Forms.Button btnSalirDificil;
    }
}