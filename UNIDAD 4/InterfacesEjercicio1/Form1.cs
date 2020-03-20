using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesEjercicio1
{
    public partial class Form1 : Form
    {
        Convertidora objconvertir = new Convertidora();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objconvertir.Dolar = Convert.ToDouble(txtPesos.Text.ToString());
            objconvertir.DolarPesos();
            lblResultado.Text = objconvertir.Pesos.ToString();
        }
    }
}
