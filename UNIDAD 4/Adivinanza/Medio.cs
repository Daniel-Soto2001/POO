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
    public partial class fmrMedio : Form
    {
        ClaseMedio objmedio = new ClaseMedio();
        public fmrMedio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirMedio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptarMedio_Click(object sender, EventArgs e)
        {
            Random Medio = new Random();
            objmedio.NumeroGanador =Medio.Next(5);
            objmedio.NumeroIntroducir = int.Parse(txtNumeroMedio.Text.ToString());
            objmedio.CalcularNumero();
            lblResultadoMedio.Text = objmedio.Resultado.ToString();
            MessageBox.Show(objmedio.ResultadoOpcion);
        }

        private void btnReiniciarMedio_Click(object sender, EventArgs e)
        {
            lblResultadoMedio.Text = "";
        }
    }
}
