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

namespace Ejercicio_2_N_paises
{
    public partial class Form1 : Form
    {
        Paises[] objpais = new Paises[7];

        int vector;
        int contador = 0;
        int cantidad;
        string[,] SelecPais;
        int index;
        TextWriter Ejercicio2Paises;

        public Form1()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ejercicio2Paises = new StreamWriter("Ejercicio2Paises.txt");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            vector = int.Parse(txtBuscar.Text);

        }

       

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Entrada de Datos
            cantidad = Convert.ToInt32(txtPais.Text);
            //Inicializamos la matriz
            SelecPais = new string[cantidad, 6];
            //Para ingresar datos a la matriz
            for (int i = 0; i < cantidad; i++)
            {
                SelecPais[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingresar nombre del pais" + (i + 1));
                SelecPais[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingresar cantidad de poblacion " + (i + 1));
                SelecPais[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingresar idioma del pais " + (i + 1));
                SelecPais[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Ingresar 1 color principal de la bandera del pais " + (i + 1));
                SelecPais[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Ingresar 2 color principal de la bandera del pais " + (i + 1));
                SelecPais[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Ingresar 3 color principal de la bandera del pais  " + (i + 1));
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string pais;
            //Entrada de Datos
            pais = txtBuscar.Text;
            //Filtramos el plato en la matriz

            for (int i = 0; i < cantidad; i++)
            {
                if (SelecPais[i, 0].Equals(pais))
                {
                    txtPaises.Text = SelecPais[i, 0];
                    txtPoblacion.Text = SelecPais[i, 1];
                    txtIdioma.Text = SelecPais[i, 2];
                    txtColor1.Text = SelecPais[i, 3];
                    txtColor2.Text = SelecPais[i, 4];
                    txtColor3.Text = SelecPais[i, 5];


                    index = i;

                    Ejercicio2Paises.WriteLine(txtPaises.Text);
                    Ejercicio2Paises.WriteLine(txtPoblacion.Text);
                    Ejercicio2Paises.WriteLine(txtIdioma.Text);
                    Ejercicio2Paises.WriteLine(txtColor1.Text);
                    Ejercicio2Paises.WriteLine(txtColor2.Text);
                    Ejercicio2Paises.WriteLine(txtColor3.Text);
                    Ejercicio2Paises.Close();
                }

            }
        }
    }
}
