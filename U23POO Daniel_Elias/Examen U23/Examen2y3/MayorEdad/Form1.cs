using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorEdad
{
    public partial class Form1 : Form
    {
        ClassPersona objPersona = new ClassPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objPersona.anoActual = int.Parse(DateTime.Today.Year.ToString());
            objPersona.MesActual = int.Parse(DateTime.Today.Month.ToString());
            objPersona.DiaActual = int.Parse(DateTime.Today.Day.ToString());
            objPersona.anoNacimiento = int.Parse(dtpFechas.Value.Year.ToString());
            objPersona.MesNacimiento = int.Parse(dtpFechas.Value.Month.ToString());
            objPersona.DiaNacimiento = int.Parse(dtpFechas.Value.Day.ToString());
            objPersona.MayordeEdad();
            lblMayor.Text = objPersona.MayorEdad.ToString();
            objPersona.MayorEdad = "";
            objPersona.MenorEdad = "";





        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
