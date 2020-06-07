using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogodeProgramas
{
    public partial class fmrUnidad4 : Form
    {
        public fmrUnidad4()
        {
            InitializeComponent();
        }

        private void btnUnidad4_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmProgramas frm = new FrmProgramas();

            frm.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Vehiculos.exe");
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Operacion.exe");
        }

        private void btnIntefaces_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/InterfacesEjercicio1.exe");
        }

        private void btnFiguras_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Figuras Geometricas.exe");
        }

        private void btnEmpelado_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Empleados Restaurante.exe");
        }

        private void btnAdivinanza_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Adivinanza.exe");
        }
    }
}
