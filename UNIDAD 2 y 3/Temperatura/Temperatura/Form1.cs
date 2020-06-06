using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        ClassTemperatura objTemperatura = new ClassTemperatura();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objTemperatura.ingresagrados = cmbTipo.Text.ToString();
            objTemperatura.grados = int.Parse(txtGrados.Text.ToString());
            objTemperatura.Grados();                     
            lblFaren.Text = objTemperatura.fahrenheit.ToString();
            lblCelsius.Text = objTemperatura.celsius.ToString();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
