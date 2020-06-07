using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class frmCalificaciones : Form
    {
        ClassCalificaciones objcalificaciones = new ClassCalificaciones();
            
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           


            objcalificaciones.califCapturados = int.Parse(txtContadorCali.Text.ToString());
            objcalificaciones.contarAprobacion();
            txtContadorCali.Text = "";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            lblApro.Text = "Aprobados: " + objcalificaciones.aprobados.ToString();
            lblRepro.Text = "Reprobados: " + objcalificaciones.reprobados.ToString();
            lblPro.Text = "Promedio: " + objcalificaciones.promedioGrupal.ToString();
                
                }

        private void txtContadorCali_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
