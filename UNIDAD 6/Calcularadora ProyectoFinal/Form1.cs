using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calcularadora_ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones objmatrices = new Operaciones();
        
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            objmatrices.InsertarA(txtFila1, txtColumna1);
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            objmatrices.InsertarB(txtFila2, txtColumna2);
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            objmatrices.MostrarA(dgv1);
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            objmatrices.MostrarB(dgv2);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            objmatrices.Suma(dgvResultados);

            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            objmatrices.Resta(dgvResultados);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            objmatrices.Multiplicar(dgvResultados);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
                
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
