using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paises_del_mundo
{
    public partial class Form1 : Form
    {
        //Objeto 
        Pais objpais = new Pais();
        TextWriter Ejercicio1Pais;
        
        
        
        
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ejercicio1Pais = new StreamWriter("Ejercicio1Pais.txt");
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                errorProvider1.SetError(txtPais, "Debe ingresar un nombre de un pais");
                txtPais.Focus();
                return;
            }
            errorProvider1.SetError(txtPais, "");

            int poblacion;
            if (!int.TryParse(txtPoblacion.Text, out poblacion))
            {
                errorProvider1.SetError(txtPoblacion, "Debe ingresar numeros en el campo de poblacion");
                txtPoblacion.Focus();
                return;
            }

            if (poblacion < 0)
            {
                errorProvider1.SetError(txtPoblacion, "Debe ingresar un numero positivo");
                txtPoblacion.Focus();
                return;
            }
            errorProvider1.SetError(txtPoblacion, "");

            if (txtIdioma.Text == "")
            {
                errorProvider1.SetError(txtIdioma, "Debe ingresar un lenguaje determinado");
                txtIdioma.Focus();
                return;

            }
            errorProvider1.SetError(txtIdioma, "");

            if (txtColor1.Text == "")
            {
                errorProvider1.SetError(txtColor1, "Debes ingresar el primer color principal de la bandera");
                txtColor1.Focus();
                return;

            }
            errorProvider1.SetError(txtColor1, "");

            if (txtColor2.Text == "")
            {
                errorProvider1.SetError(txtColor2, "Debes ingresar el segundo color principal de la bandera");
                txtColor2.Focus();
                return;

            }
            errorProvider1.SetError(txtColor2, "");

            if (txtColor3.Text == "")
            {
                errorProvider1.SetError(txtColor3, "Debes ingresar el tercer color principal de la bandera");
                txtColor3.Focus();
                return;

            }
            errorProvider1.SetError(txtColor3, "");

            objpais.NombrePais = txtPais.Text;
            objpais.Poblacion = Convert.ToInt32(txtPoblacion.Text.ToString());
            objpais.Idioma = txtIdioma.Text;
            objpais.ColoresPais= new string[3];
            objpais.ColoresPais[0] = txtColor1.Text.ToString();
            objpais.ColoresPais[1] = txtColor2.Text.ToString();
            objpais.ColoresPais[2] = txtColor3.Text.ToString();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lblPais.Text = objpais.NombrePais;
            lblPoblacion.Text = objpais.Poblacion.ToString();
            lblIidioma.Text = objpais.Idioma;
            lblColor1.Text = objpais.ColoresPais[0];
            lblColor2.Text = objpais.ColoresPais[1];
            lblColor3.Text = objpais.ColoresPais[2];
            

            MessageBox.Show("Tus datos han sido registradros");

            txtPais.Clear();
            txtPoblacion.Clear();
            txtIdioma.Clear();
            txtColor1.Clear();
            txtColor2.Clear();
            txtColor3.Clear();

            Ejercicio1Pais.WriteLine(objpais.NombrePais);
            Ejercicio1Pais.WriteLine(objpais.Poblacion);
            Ejercicio1Pais.WriteLine(objpais.Idioma);
            Ejercicio1Pais.WriteLine(objpais.ColoresPais[0]);
            Ejercicio1Pais.WriteLine(objpais.ColoresPais[1]);
            Ejercicio1Pais.WriteLine(objpais.ColoresPais[2]);
            Ejercicio1Pais.Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
           
        }
    }
    }

