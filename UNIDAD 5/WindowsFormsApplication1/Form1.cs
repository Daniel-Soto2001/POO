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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i, j;
        int filas, columnas;
        String AcumArray;
        int[,] ArrayBidi = new int[100, 100];
        String acumPar;
        int buscar;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AcumArray, "Elementos del arreglo" , MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtColumnas.Text = "";
            txtFilas.Text = "";
            AcumArray = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int filas, columnas;
            filas = Convert.ToInt32(txtFilas);
            columnas = Convert.ToInt32(txtColumnas);

            int[,] ArrayBidi = new int[10, 10];

            for (i = 0; i < filas; i++)
            {
                AcumArray += "\n";
                
                for(j=0; j<columnas;j++)
                {
                    ArrayBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingrese el valor" + 1 + " ," + j));
                    AcumArray += ArrayBidi[i, j] + ",";

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            for (i = 0; i < filas; i++)
            {
                acumPar += "\n";

                for (j = 0; j < columnas; j++)
                {
                    if (ArrayBidi[i, j] % 2 == 0)
                    {
                        acumPar += ArrayBidi[i, j];
                    }
                }
            }
            MessageBox.Show(acumPar, "Numeros Pares", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            Operaciones objOper = new Operaciones();
            objOper.Show();
            this.Hide();



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar = Convert.ToInt16(txtBuscar);
            for (i = 0; i < filas; i++)
            {
                AcumArray += "\n";

                for (j = 0; j < columnas; j++)
                {
                    if (ArrayBidi[i, j] == buscar)
                    {
                        MessageBox.Show(Convert.ToString(buscar), "El numero si existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }

                }
            }
        }

        
    }

