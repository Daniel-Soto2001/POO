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
    public partial class fmrAdivinaNumero : Form
    {               
      
        public fmrAdivinaNumero()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            

        }

        private void fmrAdivinaNumero_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (ckbFacil.Checked == true)
            {
                fmrFacil Facil = new fmrFacil();
                Facil.Show();
            }
            if(ckbMedio.Checked==true)
            {
                fmrMedio Medio = new fmrMedio();
                Medio.Show();
            }
            if(ckbDificil.Checked==true)
            {
                fmrDificil Dificil = new fmrDificil();
                Dificil.Show();
            }
        
        }
    }
}
