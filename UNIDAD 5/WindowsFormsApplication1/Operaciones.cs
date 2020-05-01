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

namespace WindowsFormsApplication1
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }
        int[,] arrayA = new int[100, 100];
        int[,] arrayB = new int[100,100];
        int[,] arrayC = new int[100, 100];
        int fila;
        int columna;
        int i, j;
        String acumA;
        String acumB;
        String acumC;

        private void Operaciones_Load(object sender, EventArgs e)
        {
          
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            fila = Convert.ToInt16(Interaction.InputBox("Cuantas filas tiene la matriz?"));
            fila = Convert.ToInt16(Interaction.InputBox("Cuantas columnas?"));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < columna; j++)
                {
                    arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtDato2.Text = acumC;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDato1.Text = "";
            txtDato2.Text = "";
            txtResultado.Text = "";
            acumA = "";
            acumB = "";
            acumC = "";


        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < columna; j++)
                {
                    arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtResultado.Text = acumC;
                }
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < columna; j++)
                {
                    arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtResultado.Text = acumC;
                }
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < columna; j++)
                {
                    arrayC[i, j] = arrayA[i, j] / arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtResultado.Text = acumC;
                }
            }
        }

        private void btnDatosB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz B", "Ingresar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            for (i = 0; i < fila; i++)
            {
                acumA += "\r\n";
                for (j = 0; j < columna; j++)
                {
                    arrayB[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz B" + i + ", " + j));
                    acumB += arrayB[i, j] + "\n";
                    txtDato2.Text = acumB;
                }
            }
        }

        private void btnDatosA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz A", "Ingresar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            for (i=0; i<fila; i++)
            {
                acumA += "\r\n";
                for(j=0; j<columna; j++)
                {
                    arrayA[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz A " + i + ", " + j));
                    acumA += arrayA[i,j]+"\n";
                    txtDato1.Text = acumA;
                }
            }
        }
    }
}
