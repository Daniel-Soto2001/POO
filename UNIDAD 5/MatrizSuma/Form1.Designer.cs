namespace MatrizSumaFCD
{
    partial class frmFCD
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudFilCol = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFilas = new System.Windows.Forms.Button();
            this.btnColumnas = new System.Windows.Forms.Button();
            this.btnDiagonales = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumFil = new System.Windows.Forms.TextBox();
            this.txtSumCol = new System.Windows.Forms.TextBox();
            this.txtSumDia = new System.Windows.Forms.TextBox();
            this.txtTotalFil = new System.Windows.Forms.TextBox();
            this.txtTotalCol = new System.Windows.Forms.TextBox();
            this.btnTotalCol = new System.Windows.Forms.Button();
            this.btnTotalFil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilCol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuantas filas y columnas agregara:";
            // 
            // nudFilCol
            // 
            this.nudFilCol.Location = new System.Drawing.Point(189, 7);
            this.nudFilCol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFilCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFilCol.Name = "nudFilCol";
            this.nudFilCol.Size = new System.Drawing.Size(41, 20);
            this.nudFilCol.TabIndex = 1;
            this.nudFilCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(245, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFilas
            // 
            this.btnFilas.Location = new System.Drawing.Point(245, 52);
            this.btnFilas.Name = "btnFilas";
            this.btnFilas.Size = new System.Drawing.Size(75, 23);
            this.btnFilas.TabIndex = 3;
            this.btnFilas.Text = "Imprimir filas";
            this.btnFilas.UseVisualStyleBackColor = true;
            this.btnFilas.Click += new System.EventHandler(this.btnFilas_Click);
            // 
            // btnColumnas
            // 
            this.btnColumnas.Location = new System.Drawing.Point(245, 81);
            this.btnColumnas.Name = "btnColumnas";
            this.btnColumnas.Size = new System.Drawing.Size(75, 34);
            this.btnColumnas.TabIndex = 4;
            this.btnColumnas.Text = "Imprimir columnas";
            this.btnColumnas.UseVisualStyleBackColor = true;
            this.btnColumnas.Click += new System.EventHandler(this.btnColumnas_Click);
            // 
            // btnDiagonales
            // 
            this.btnDiagonales.Location = new System.Drawing.Point(245, 121);
            this.btnDiagonales.Name = "btnDiagonales";
            this.btnDiagonales.Size = new System.Drawing.Size(75, 38);
            this.btnDiagonales.TabIndex = 5;
            this.btnDiagonales.Text = "Imprimir Diagonales";
            this.btnDiagonales.UseVisualStyleBackColor = true;
            this.btnDiagonales.Click += new System.EventHandler(this.btnDiagonales_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sumatoria  filas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sumatoria columnas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sumatoria diagonales:";
            // 
            // txtSumFil
            // 
            this.txtSumFil.Location = new System.Drawing.Point(123, 54);
            this.txtSumFil.Name = "txtSumFil";
            this.txtSumFil.Size = new System.Drawing.Size(100, 20);
            this.txtSumFil.TabIndex = 9;
            // 
            // txtSumCol
            // 
            this.txtSumCol.Location = new System.Drawing.Point(123, 89);
            this.txtSumCol.Name = "txtSumCol";
            this.txtSumCol.Size = new System.Drawing.Size(100, 20);
            this.txtSumCol.TabIndex = 10;
            // 
            // txtSumDia
            // 
            this.txtSumDia.Location = new System.Drawing.Point(123, 131);
            this.txtSumDia.Name = "txtSumDia";
            this.txtSumDia.Size = new System.Drawing.Size(100, 20);
            this.txtSumDia.TabIndex = 11;
            // 
            // txtTotalFil
            // 
            this.txtTotalFil.Location = new System.Drawing.Point(355, 54);
            this.txtTotalFil.Name = "txtTotalFil";
            this.txtTotalFil.Size = new System.Drawing.Size(55, 20);
            this.txtTotalFil.TabIndex = 12;
            // 
            // txtTotalCol
            // 
            this.txtTotalCol.Location = new System.Drawing.Point(355, 95);
            this.txtTotalCol.Name = "txtTotalCol";
            this.txtTotalCol.Size = new System.Drawing.Size(55, 20);
            this.txtTotalCol.TabIndex = 13;
            // 
            // btnTotalCol
            // 
            this.btnTotalCol.Location = new System.Drawing.Point(416, 87);
            this.btnTotalCol.Name = "btnTotalCol";
            this.btnTotalCol.Size = new System.Drawing.Size(93, 35);
            this.btnTotalCol.TabIndex = 14;
            this.btnTotalCol.Text = "Suma de todas las columnas";
            this.btnTotalCol.UseVisualStyleBackColor = true;
            this.btnTotalCol.Click += new System.EventHandler(this.btnTotalCol_Click);
            // 
            // btnTotalFil
            // 
            this.btnTotalFil.Location = new System.Drawing.Point(416, 46);
            this.btnTotalFil.Name = "btnTotalFil";
            this.btnTotalFil.Size = new System.Drawing.Size(93, 35);
            this.btnTotalFil.TabIndex = 15;
            this.btnTotalFil.Text = "Suma de todas las filas";
            this.btnTotalFil.UseVisualStyleBackColor = true;
            this.btnTotalFil.Click += new System.EventHandler(this.btnTotalFil_Click);
            // 
            // frmFCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 175);
            this.Controls.Add(this.btnTotalFil);
            this.Controls.Add(this.btnTotalCol);
            this.Controls.Add(this.txtTotalCol);
            this.Controls.Add(this.txtTotalFil);
            this.Controls.Add(this.txtSumDia);
            this.Controls.Add(this.txtSumCol);
            this.Controls.Add(this.txtSumFil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDiagonales);
            this.Controls.Add(this.btnColumnas);
            this.Controls.Add(this.btnFilas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudFilCol);
            this.Controls.Add(this.label1);
            this.Name = "frmFCD";
            this.Text = "Sumatoria";
            this.Load += new System.EventHandler(this.frmFCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFilCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFilCol;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFilas;
        private System.Windows.Forms.Button btnColumnas;
        private System.Windows.Forms.Button btnDiagonales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSumFil;
        private System.Windows.Forms.TextBox txtSumCol;
        private System.Windows.Forms.TextBox txtSumDia;
        private System.Windows.Forms.TextBox txtTotalFil;
        private System.Windows.Forms.TextBox txtTotalCol;
        private System.Windows.Forms.Button btnTotalCol;
        private System.Windows.Forms.Button btnTotalFil;
    }
}

