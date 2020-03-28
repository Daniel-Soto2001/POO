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
    
    public partial class fmrFacil : Form
    {
        ClaseFacil objfacil = new ClaseFacil();
       
        public fmrFacil()
        {
            InitializeComponent();
        }

        private void btnAceptarFacil_Click(object sender, EventArgs e)
        {
            
            Random Facil = new Random();
            objfacil.NumeroGanador = Facil.Next(3);
            objfacil.NumeroIntroducir = int.Parse(txtNumeroFacil.Text.ToString());
            objfacil.CalcularNumero();
            lblResultadoFacil.Text = objfacil.Resultado.ToString();
            MessageBox.Show( objfacil.ResultadoOpcion);
        }

        private void Facil_Load(object sender, EventArgs e)
        {

        }

        private void btnReiniciarFacil_Click(object sender, EventArgs e)
        {
            lblResultadoFacil.Text = "";
            txtNumeroFacil.Text = "";

        }

        private void btnSalirFacil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
