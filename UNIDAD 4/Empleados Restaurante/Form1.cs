using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados_Restaurante
{
    public partial class Form1 : Form
    {
        Mesero objmesero = new Mesero();
        Cajero objcaja = new Cajero();
        Repartidor objrepartidor = new Repartidor();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularMesero_Click(object sender, EventArgs e)
        {
            objmesero.Anoactu = int.Parse(DateTime.Today.Year.ToString());
            objmesero.Mesactu = int.Parse(DateTime.Today.Month.ToString());
            objmesero.Diaactu = int.Parse(DateTime.Today.Day.ToString());
            objmesero.Anonac = int.Parse(dateTimePicker1.Value.Year.ToString());
            objmesero.Mesnac = int.Parse(dateTimePicker1.Value.Month.ToString());
            objmesero.Dianac = int.Parse(dateTimePicker1.Value.Day.ToString());
            objmesero.Nombre = txtNombre.Text;
        objmesero.Salario = cmbDias.Text.ToString();
        objmesero.Propinasemanal = Convert.ToDouble(txtPropina.Text.ToString());
        objmesero.Sueldo = Convert.ToDouble(txtSueldos.Text.ToString());
        objmesero.Calcularsueldo();
            lblSalarioMesero.Text = objmesero.Salariosemanal.ToString();
            MessageBox.Show("El sueldo semanal de "+ objmesero.Nombre +  " es " + objmesero.Salariosemanal);
        }

        private void gbxCaja_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcularCaja_Click(object sender, EventArgs e)
        {
            objcaja.Anoactu = int.Parse(DateTime.Today.Year.ToString());
            objcaja.Mesactu = int.Parse(DateTime.Today.Month.ToString());
            objcaja.Diaactu = int.Parse(DateTime.Today.Day.ToString());
            objcaja.Anonac = int.Parse(dateTimePicker1.Value.Year.ToString());
            objcaja.Mesnac = int.Parse(dateTimePicker1.Value.Month.ToString());
            objcaja.Dianac = int.Parse(dateTimePicker1.Value.Day.ToString());
            objcaja.Nombre = txtName.Text;
            objcaja.Diastrabajados = int.Parse(cmbCaja.Text);
            objcaja.Sueldo = Convert.ToDouble(txtSueldo.Text);
            objcaja.Cajas = cmbCajas.Text;
            objcaja.Calcularsueldo();
            lblSalariocaja.Text = objcaja.Salariosemanal.ToString();
            MessageBox.Show(  " El sueldo semanal de " + objcaja.Nombre + " es " + objcaja.Salariosemanal);



        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objrepartidor.Anoactu = int.Parse(DateTime.Today.Year.ToString());
            objrepartidor.Mesactu = int.Parse(DateTime.Today.Month.ToString());
            objrepartidor.Diaactu = int.Parse(DateTime.Today.Day.ToString());
            objrepartidor.Anonac = int.Parse(dateTimePicker1.Value.Year.ToString());
            objrepartidor.Mesnac = int.Parse(dateTimePicker1.Value.Month.ToString());
            objrepartidor.Dianac = int.Parse(dateTimePicker1.Value.Day.ToString());
            objrepartidor.Nombre = txtName2.Text;
            objrepartidor.Sueldo = Convert.ToDouble(txtSueldoRepartidor.Text);
            objrepartidor.Diastrabajados = int.Parse(cmbRepartidor.Text.ToString());       
            objrepartidor.Zonareparto =(cmbZonas.Text);
            objrepartidor.Abonos = int.Parse(txtPedidos.Text);
            objrepartidor.Calcularsueldo();
            lblSalariosemanalrepartidor.Text = objrepartidor.Salariosemanal.ToString();
            MessageBox.Show("El sueldo semanal de " + objrepartidor.Nombre + " es " + objrepartidor.Salariosemanal);
        }
    }
}

