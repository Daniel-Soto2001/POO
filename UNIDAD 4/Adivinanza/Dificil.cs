using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinanza
{
    
    public partial class fmrDificil : Form
    {
        ClaseDificil objdificil = new ClaseDificil();
        public fmrDificil()
        {
            InitializeComponent();
        }

        private void btnReiniciiarDificil_Click(object sender, EventArgs e)
        {
            lblResultadoDificil.Text = "";
            txtNumeroDificil.Text = "";
        }

        private void btnSalirDificil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptarDificil_Click(object sender, EventArgs e)
        {

            Random Dificil = new Random();
            objdificil.NumeroGanador = Dificil.Next(10);
            objdificil.NumeroIntroducir = int.Parse(txtNumeroDificil.Text.ToString());
            objdificil.CalcularNumero();
            lblResultadoDificil.Text = objdificil.Resultado.ToString();
            MessageBox.Show(objdificil.ResultadoOpcion);
        }
    }
}
