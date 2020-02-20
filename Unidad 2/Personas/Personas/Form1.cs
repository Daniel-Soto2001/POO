using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas
{
    public partial class Form1 : Form
    {
        ClassPersonas objpersonas = new ClassPersonas();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objpersonas.nayarit = cmbEstados.Text.ToString();
            objpersonas.tipo = cmbTipo.Text.ToString();            
            objpersonas.contadornayarit = int.Parse(cmbEstados.Text.ToString());
            objpersonas.contadormayor = int.Parse(txtNacimiento.Text.ToString());
            objpersonas.contadortipo = int.Parse(cmbTipo.Text.ToString());
            objpersonas.Estados();
            objpersonas.Tipos();
            textBox1.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            txtNacimiento.Text = "";
            cmbEstados.Text = "";
            cmbTipo.Text = "";
            MessageBox.Show("Se guardaron tus datos");

        }
    }
}
