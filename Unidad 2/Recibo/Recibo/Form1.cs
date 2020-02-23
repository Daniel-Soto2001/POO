using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo
{
    public partial class Form1 : Form
    {
        ClassRecibo objrecibo = new ClassRecibo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            objrecibo.kilo = int.Parse(txtKilo.Text.ToString());
            objrecibo.KilowattsHogar();
            objrecibo.KilowattsNegocio();
            lblResultado.Text = objrecibo.resukilo.ToString();
            lblResultado.Text = objrecibo.resunego.ToString();
            
        }
    }
}
