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
    public partial class frmCuadrado : Form
    {
        Cuadrado objcuadrado = new Cuadrado();
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objcuadrado.Lado = float.Parse(txtLado.Text.ToString());
            objcuadrado.CalcularPerimetro();
            objcuadrado.CalcularArea();
            lblArea.Text = objcuadrado.Area.ToString();
            lblPerimetro.Text = objcuadrado.Perimetro.ToString();
           
        }

        private void frmCuadrado_Load(object sender, EventArgs e)
        {

        }
    }
}
