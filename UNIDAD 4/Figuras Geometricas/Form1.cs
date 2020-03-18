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
    public partial class frmOriginal : Form
    {
        public frmOriginal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxCuadrado.Checked == true)
            {
                frmCuadrado Cuadrado = new frmCuadrado();
                Cuadrado.Show();
            }
            if (cbxTriangulo.Checked == true)
            {
                frmTriangulo Triangulo = new frmTriangulo();
                Triangulo.Show();
            }
            if (cbxCirculo.Checked == true)
            {
                frmCirculo Circulo = new frmCirculo();
                Circulo.Show();
            }
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxCuadrado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
