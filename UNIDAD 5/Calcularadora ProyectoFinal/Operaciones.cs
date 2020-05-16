using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Calcularadora_ProyectoFinal
{
    class Operaciones
    {
        public int Fila1 { get; set; }
        public int Fila2 { get; set; }
        public int Columna1 { get; set; }
        public int Columna2 { get; set; }

        int [,] MatrizA = new int [100, 100];
        int [,] MatrizB = new int [100, 100];
        int [,] Resultado = new int [100,100];
        int i, j, z;

        public void InsertarA(TextBox Pantalla1, TextBox Pantalla2)
        {
            if(Pantalla1.Text==""|| Pantalla2.Text=="")
            {
                MessageBox.Show("Ingrese Datos");
            }
            else
            {
                Fila1 = int.Parse(Pantalla1.Text);
                Columna1 = int.Parse(Pantalla2.Text);

                for(i=0; i<Columna1; i++)
                {
                    for(j=0; j<Columna1; j++)
                    {
                        MatrizA[i, j] = int.Parse(Interaction.InputBox("Ingresa un numero", "Ingrese otro numero","", Fila1, Columna1));
                            
                    }
                }
            }
        }

        public void InsertarB(TextBox Pantalla3, TextBox Pantalla4)
        {
            if(Pantalla3.Text=="" || Pantalla4.Text=="")
            {
                MessageBox.Show("Ingrese Datos");
            }
            else
            {
                Fila2 = int.Parse(Pantalla3.Text);
                Columna2 = int.Parse(Pantalla4.Text);

                for(i=0; i<Fila2; i++)
                {
                    for(j=0; j<Columna2; j++)
                    {
                        MatrizB[i, j] = int.Parse(Interaction.InputBox("Ingrese numero", "Ingrese otro numero", "", Fila2, Columna2));
                    }
                }
            }
        }

        public void MostrarA(DataGridView Tabla)
        {
            Tabla.RowCount = Fila1;
            Tabla.ColumnCount = Columna1;

            for(i=0; i<Fila1; i++)
            {
                for(j=0; j<Columna1; j++)
                    {
                    Tabla.Rows[i].Cells[j].Value = MatrizA[i,j].ToString();
                    }
            }
        }

        public void MostrarB(DataGridView Tabla)
        {
            Tabla.RowCount = Fila2;
            Tabla.ColumnCount = Columna2;

            for (i = 0; i < Fila2; i++)
            {
                for (j = 0; j < Columna2; j++)
                {
                    Tabla.Rows[i].Cells[j].Value = MatrizB[i,j].ToString();
                }
            }
        }
        public void Suma(DataGridView Suma)
        {
            if (Fila1 == Fila2 && Columna1 == Columna2)
            { 
                Suma.RowCount = Fila1;
            Suma.ColumnCount = Columna2;
            
                for (i = 0; i < Fila1; i++)
                {
                    for (j = 0; j < Columna2; j++)
                    {
                        Resultado[i, j] = MatrizA[i, j] + MatrizB[i, j];
                        Suma.Rows[i].Cells[j].Value = Resultado[i, j].ToString();

                    }
                }
            }
            else
            {
                MessageBox.Show("Tienen que ser iguales las filas y columnas");
            }
           
        }

        public void Resta(DataGridView Resta)
        {
            if (Fila1 == Fila2 && Columna1 == Columna2)
            {
                Resta.RowCount = Fila1;
                Resta.ColumnCount = Columna2;

                for (i = 0; i < Fila1; i++)
                {
                    for (j = 0; j < Columna2; j++)
                    {
                        Resultado[i, j] = MatrizA[i, j] - MatrizB[i, j];
                        Resta.Rows[i].Cells[j].Value = Resultado[i, j].ToString();

                    }
                }
            }
            else
            {
                MessageBox.Show("Tienen que ser iguales las filas y columnas");
            }

        }

        public void Multiplicar(DataGridView Multiplica)
        {
            Multiplica.RowCount = Fila1;
            Multiplica.ColumnCount = Columna2;

            for(i=0; i<Fila1; i++)
            {
                for(j=0; j<Columna2; j++)
                {
                    Resultado[i, j] = 0;
                    for(z=0; z<Columna1; z++)
                    {
                        Resultado[i,j]=(MatrizA[i,z]* MatrizB[z,j]) + Resultado[i, j];
                        Multiplica.Rows[i].Cells[j].Value = Resultado[i,j].ToString();

                    }
                }
            }



        }












    }
}
