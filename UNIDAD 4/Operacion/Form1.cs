using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_4
{
    public partial class Form1 : Form
    {
        Suma objsuma = new Suma();
        Resta objresta = new Resta();
        Multiplicacion objmultiplicar = new Multiplicacion();
        Division objdividir = new Division();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objsuma.Valor1 = Convert.ToDouble(txtValor1.Text);
            objsuma.Valor2 = Convert.ToDouble(txtValor2.Text);
            objsuma.sumar();
            lblSuma.Text = objsuma.Resultado.ToString();
                

           
            objresta.Valor1 = Convert.ToDouble(txtValor1.Text);
            objresta.Valor2 = Convert.ToDouble(txtValor2.Text);
            objresta.restar();               
            lblResta.Text = objresta.Resultado.ToString();

            objmultiplicar.Valor1 = Convert.ToDouble(txtValor1.Text);
            objmultiplicar.Valor2 = Convert.ToDouble(txtValor2.Text);
            objmultiplicar.multiplicar();
            lblMultiplicar.Text = objmultiplicar.Resultado.ToString();

            objdividir.Valor1 = Convert.ToDouble(txtValor1.Text);
            objdividir.Valor2 =Convert.ToDouble(txtValor2.Text);
            objdividir.dividir();
            lblDivision.Text = objdividir.Resultado.ToString();
            

            


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}