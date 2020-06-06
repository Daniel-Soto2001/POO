using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bidimensional2
{
    public partial class frmBidimensional : Form
    {
        public frmBidimensional()
        {
            InitializeComponent();
           
        }
        int i, j;
        String acumArray;
        int[,] arrayBidi = new int[100, 100];
        String AcumPar;
        int Buscar;
        int Filas, Columnas;
        TextWriter Bidimensional3;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          MessageBox.Show(acumArray,"Elementos del Arreglo",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            Bidimensional3.WriteLine(txtFila.Text);
            Bidimensional3.WriteLine(txtColumna.Text);
            Bidimensional3.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
             Filas = Convert.ToInt16(txtFila.Text);
            Columnas = Convert.ToInt16(txtColumna.Text);

            for (i = 0; i < Filas; i++)
            {
                acumArray += "\n";

                for (j = 0; j < Columnas; j++)
                {
                    arrayBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingresa el valor " + i + "," + j));
                    acumArray += arrayBidi[i, j] + ",";
                }
            }
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            frmOperaciones Operaciones = new frmOperaciones();
            Operaciones.Show();
            this.Hide();
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            for (i = 0; i < Filas; i++)
            {
                AcumPar += "\n";
                for (j = 0; j < Columnas; j++)
                {
                    if (arrayBidi[i, j] % 2 == 0)
                    {
                        AcumPar += arrayBidi[i, j];
                    }
                }
            }
            MessageBox.Show(AcumPar, "Números pares", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void frmBidimensional_Load(object sender, EventArgs e)
        {
            Bidimensional3 = new StreamWriter("Bidimensional3.txt");
        }

        private void txtFila_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar = Convert.ToInt16(txtBuscar.Text);
            for (i = 0; i < Filas; i++)
            {
                acumArray += "\n";
                for (j = 0; j < Columnas; j++)
                {
                    if(arrayBidi[i,j]==Buscar)
                    {
                        MessageBox.Show(Convert.ToString(Buscar), "El numero si existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }                                        
                }
            }
        }

        public void LimpiarControles()
        {
            txtFila.Text = "";
            txtColumna.Text = "";
            acumArray = "";
        }
    }
}
