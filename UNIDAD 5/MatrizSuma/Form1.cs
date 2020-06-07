using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace MatrizSumaFCD
{
    public partial class frmFCD : Form
    {
        ClaseSumaFCD objFCD = new ClaseSumaFCD();
        string AcumF;
        string AcumC;

        public frmFCD()
        {
            InitializeComponent();
            btnColumnas.Enabled = false;
            btnDiagonales.Enabled = false;
            btnFilas.Enabled = false;
            btnTotalCol.Enabled = false;
            btnTotalFil.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objFCD.Cant = (int)nudFilCol.Value;

            objFCD.FilCol = new string[objFCD.Cant, objFCD.Cant];
            for(int f=0; f<objFCD.FilCol.GetLength(0);f++)
            {
                objFCD.FilCol[f, 0] = Microsoft.VisualBasic.Interaction.InputBox("Agrega un numero " + (f + 1) + " Filas");
               
                for (int c = 1; c < objFCD.FilCol.GetLength(1); c++)
                {
                    objFCD.FilCol[f, c] = Microsoft.VisualBasic.Interaction.InputBox("Agrega otro numero " + (c + 1) + " columnas");
                }
            }
            btnColumnas.Enabled = true;
            btnDiagonales.Enabled = true;
            btnFilas.Enabled = true;
            btnTotalCol.Enabled = true;
            btnTotalFil.Enabled = true;
        }

        private void btnFilas_Click(object sender, EventArgs e)
        {
            objFCD.Fila = new int[objFCD.Cant];
            objFCD.SumaFilas();
            for (int f = 0; f < objFCD.Cant; f++)
            {
                AcumF += objFCD.Fila[f] + " ";
                txtSumFil.Text = AcumF;
            }
           
        }

        private void btnColumnas_Click(object sender, EventArgs e)
        {
            objFCD.Colu = new int[objFCD.Cant];
            objFCD.SumaColumnas();
            for(int c=0;c<objFCD.Cant;c++)
            {
                AcumC += objFCD.Colu[c] + " ";
                txtSumCol.Text = AcumC;
            }
            
        }

        private void btnDiagonales_Click(object sender, EventArgs e)
        {
            

        }

        private void btnTotalFil_Click(object sender, EventArgs e)
        {
        
            
        }

        private void btnTotalCol_Click(object sender, EventArgs e)
        {
            
           
        }

        private void frmFCD_Load(object sender, EventArgs e)
        {
            

        }
    }
}
