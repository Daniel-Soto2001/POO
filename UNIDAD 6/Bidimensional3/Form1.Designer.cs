namespace Bidimensional2
{
    partial class frmBidimensional
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
            this.gbxArregloBidimensiona = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.lblFilas = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.lblBuscarNumero = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNumerosPares = new System.Windows.Forms.Label();
            this.gbxArregloBidimensiona.SuspendLayout();
            this.gbxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxArregloBidimensiona
            // 
            this.gbxArregloBidimensiona.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gbxArregloBidimensiona.Controls.Add(this.btnImprimir);
            this.gbxArregloBidimensiona.Controls.Add(this.btnIngresar);
            this.gbxArregloBidimensiona.Controls.Add(this.lblColumnas);
            this.gbxArregloBidimensiona.Controls.Add(this.txtColumna);
            this.gbxArregloBidimensiona.Controls.Add(this.lblFilas);
            this.gbxArregloBidimensiona.Controls.Add(this.txtFila);
            this.gbxArregloBidimensiona.Location = new System.Drawing.Point(57, 59);
            this.gbxArregloBidimensiona.Name = "gbxArregloBidimensiona";
            this.gbxArregloBidimensiona.Size = new System.Drawing.Size(245, 150);
            this.gbxArregloBidimensiona.TabIndex = 0;
            this.gbxArregloBidimensiona.TabStop = false;
            this.gbxArregloBidimensiona.Text = "Arreglo Bidimensional";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(134, 121);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(22, 121);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnas.Location = new System.Drawing.Point(140, 45);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(61, 13);
            this.lblColumnas.TabIndex = 3;
            this.lblColumnas.Text = "Columnas";
            this.lblColumnas.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(123, 80);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(100, 20);
            this.txtColumna.TabIndex = 2;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilas.Location = new System.Drawing.Point(39, 45);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(33, 13);
            this.lblFilas.TabIndex = 1;
            this.lblFilas.Text = "Filas";
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(11, 80);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(100, 20);
            this.txtFila.TabIndex = 0;
            this.txtFila.TextChanged += new System.EventHandler(this.txtFila_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(79, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(200, 233);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Location = new System.Drawing.Point(136, 291);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(75, 23);
            this.btnOperaciones.TabIndex = 8;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.BackColor = System.Drawing.Color.DarkOrchid;
            this.gbxAcciones.Controls.Add(this.btnBuscar);
            this.gbxAcciones.Controls.Add(this.btnPar);
            this.gbxAcciones.Controls.Add(this.lblBuscarNumero);
            this.gbxAcciones.Controls.Add(this.txtBuscar);
            this.gbxAcciones.Controls.Add(this.lblNumerosPares);
            this.gbxAcciones.Location = new System.Drawing.Point(333, 59);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(245, 150);
            this.gbxAcciones.TabIndex = 9;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "Acciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(134, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(22, 80);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 4;
            this.btnPar.Text = "Par";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // lblBuscarNumero
            // 
            this.lblBuscarNumero.AutoSize = true;
            this.lblBuscarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNumero.Location = new System.Drawing.Point(120, 45);
            this.lblBuscarNumero.Name = "lblBuscarNumero";
            this.lblBuscarNumero.Size = new System.Drawing.Size(93, 13);
            this.lblBuscarNumero.TabIndex = 3;
            this.lblBuscarNumero.Text = "Buscar Numero";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(123, 80);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblNumerosPares
            // 
            this.lblNumerosPares.AutoSize = true;
            this.lblNumerosPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerosPares.Location = new System.Drawing.Point(19, 45);
            this.lblNumerosPares.Name = "lblNumerosPares";
            this.lblNumerosPares.Size = new System.Drawing.Size(92, 13);
            this.lblNumerosPares.TabIndex = 1;
            this.lblNumerosPares.Text = "Numeros Pares";
            // 
            // frmBidimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 346);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxArregloBidimensiona);
            this.Name = "frmBidimensional";
            this.Text = "Bidimensional";
            this.Load += new System.EventHandler(this.frmBidimensional_Load);
            this.gbxArregloBidimensiona.ResumeLayout(false);
            this.gbxArregloBidimensiona.PerformLayout();
            this.gbxAcciones.ResumeLayout(false);
            this.gbxAcciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxArregloBidimensiona;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.GroupBox gbxAcciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Label lblBuscarNumero;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNumerosPares;
    }
}

