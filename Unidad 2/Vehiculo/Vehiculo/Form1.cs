using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculo
{
    public partial class Form1 : Form
    {
        ClassVehiculo objvehiculo = new ClassVehiculo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objvehiculo.cuota = cmbVehiculo.Text.ToString();
            lblResultado.Text = objvehiculo.Motociclista.ToString();
            lblResultado.Text = objvehiculo.Automovil.ToString();
            lblResultado.Text = objvehiculo.Autobus.ToString();
            lblResultado.Text = objvehiculo.Trailer.ToString();
            objvehiculo.Caseta();
        }
    }
}
