using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{

    public partial class frmConcierto : Form
    {
        ClassAsistente objConcierto = new ClassAsistente();

        public frmConcierto()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {




            objConcierto.personas = cmbPersonas.Text.ToString();
            objConcierto.num1 = int.Parse(cmbCuenta.Text.ToString());
            objConcierto.num2 = int.Parse(cmbCuenta.Text.ToString());
            objConcierto.num3 = int.Parse(cmbCuenta.Text.ToString());
            objConcierto.num4 = int.Parse(cmbCuenta.Text.ToString());
            objConcierto.Registro();
            cmbCuenta.Text = "";
            cmbPersonas.Text = "";
            MessageBox.Show("Se guardaron tus datos");
        }


        private void frmConcierto_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = objConcierto.bebes.ToString();
            textBox2.Text = objConcierto.niños.ToString();
            textBox3.Text = objConcierto.adultos.ToString();
            textBox4.Text = objConcierto.terceraedad.ToString();


        }

    }
}
