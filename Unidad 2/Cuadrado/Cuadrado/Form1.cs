using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrado
{
    public partial class Form1 : Form
    {
        ClassCuadrado objCuadrado = new ClassCuadrado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objCuadrado.lado = int.Parse(txtLados.Text.ToString());
            objCuadrado.PerimetroyArea();
            lblArea.Text = objCuadrado.are.ToString();           
            lblPerimetro.Text = objCuadrado.per.ToString();
        }
    }
}
