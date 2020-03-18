using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class frmCirculo : Form
    {
        Circulo objcirculo = new Circulo();
        public frmCirculo()
        {
            InitializeComponent();
        }

        private void Circulo1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objcirculo.Lado = float.Parse(txtLado.Text.ToString());
            objcirculo.CalcularPerimetro();
            objcirculo.CalcularArea();
            lblPerimetro.Text = objcirculo.Perimetro.ToString();
            lblArea.Text = objcirculo.Area.ToString();
        }
    }
}
