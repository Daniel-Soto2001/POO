namespace TorneoFutbol
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudNumeroEquipos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPerder = new System.Windows.Forms.NumericUpDown();
            this.nudEmpate = new System.Windows.Forms.NumericUpDown();
            this.nudGanar = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCampeon = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Torneo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // nudNumeroEquipos
            // 
            this.nudNumeroEquipos.Location = new System.Drawing.Point(120, 55);
            this.nudNumeroEquipos.Name = "nudNumeroEquipos";
            this.nudNumeroEquipos.Size = new System.Drawing.Size(46, 20);
            this.nudNumeroEquipos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Equipos:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(366, 114);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.Location = new System.Drawing.Point(120, 113);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(205, 20);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de Termino: ";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(120, 87);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(205, 20);
            this.dtpFechaInicio.TabIndex = 13;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // nudPerder
            // 
            this.nudPerder.Location = new System.Drawing.Point(110, 212);
            this.nudPerder.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPerder.Name = "nudPerder";
            this.nudPerder.Size = new System.Drawing.Size(47, 20);
            this.nudPerder.TabIndex = 22;
            // 
            // nudEmpate
            // 
            this.nudEmpate.Location = new System.Drawing.Point(116, 178);
            this.nudEmpate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEmpate.Name = "nudEmpate";
            this.nudEmpate.Size = new System.Drawing.Size(46, 20);
            this.nudEmpate.TabIndex = 21;
            // 
            // nudGanar
            // 
            this.nudGanar.Location = new System.Drawing.Point(110, 152);
            this.nudGanar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGanar.Name = "nudGanar";
            this.nudGanar.Size = new System.Drawing.Size(47, 20);
            this.nudGanar.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Puntos de Perdder: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Puntos de Empatar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Puntos de Ganar:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(198, 212);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCampeon
            // 
            this.btnCampeon.Location = new System.Drawing.Point(174, 261);
            this.btnCampeon.Name = "btnCampeon";
            this.btnCampeon.Size = new System.Drawing.Size(151, 40);
            this.btnCampeon.TabIndex = 24;
            this.btnCampeon.Text = "Determina el Campeon";
            this.btnCampeon.UseVisualStyleBackColor = true;
            this.btnCampeon.Click += new System.EventHandler(this.btnCampeon_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(381, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 322);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCampeon);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.nudPerder);
            this.Controls.Add(this.nudEmpate);
            this.Controls.Add(this.nudGanar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudNumeroEquipos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudNumeroEquipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPerder;
        private System.Windows.Forms.NumericUpDown nudEmpate;
        private System.Windows.Forms.NumericUpDown nudGanar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCampeon;
        private System.Windows.Forms.Button btnSalir;
    }
}

