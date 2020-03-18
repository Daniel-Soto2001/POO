using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos
{
    public partial class Form1 : Form
    {
        ClassAereo objAreo = new ClassAereo();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objAreo.TipoAereo = cmbTipo.Text.ToString();
            objAreo.arrancar = btnArrancar.Text;
            MessageBox.Show(objAreo.ArrancarMotor());
           
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            objAreo.Estado = btnEstado.Text;
            objAreo.TipoAereo = cmbTipo.Text.ToString();
            objAreo.enVuelo();
            MessageBox.Show(objAreo.enVuelo());
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            objAreo.parar = btnParar.Text;
            MessageBox.Show(objAreo.PararMotor());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            objAreo.TipoAereo = cmbTipo.Text;
            objAreo.NumTurbinas = int.Parse(txtRurbinas.Text);
            objAreo.NumHelices = int.Parse(txtHelices.Text);
            objAreo.NumAlas = Convert.ToInt32(txtAlas.Text);
            objAreo.NumAlas = Convert.ToInt32(txtAlas.Text);
            objAreo.NumeroLlantas=Convert.ToInt32(txtLlantas.Text);
            objAreo.NumeroPuertas = Convert.ToInt32(txtPuertas.Text);
            objAreo.NumeroVentanas = Convert.ToInt32(txtVentanas.Text);
            MessageBox.Show("La informacion del objeto "  + cmbTipo.Text +  "Se guardo correctamente");
        

        }
    }
}
