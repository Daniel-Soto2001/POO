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
    public partial class fmrUnidad6 : Form
    {
        public fmrUnidad6()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmProgramas frm = new FrmProgramas();

            frm.Show();
        }

        private void btnClase_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/MiPrimeraClase6.exe");
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Paises del mundo6.exe");
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejercicio 2 N paises6.exe");
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejercicio 3 EscuelaDatos.exe");
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejercicio 4 DocenteAlumnos6.exe");
        }

        private void btnEjemplo1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejemplo1Propuesto6.exe");
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/MatrizSumaFCD6.exe");
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/NumeroMayorMenor6.exe");
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/TorneoFutbol6.exe");
        }

        private void btnBidi1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Bidimensional16.exe");
        }

        private void btnBidi2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Bidimensionales 26.exe");
        }

        private void btnBidi3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Bidimensional36.exe");
        }
    }
}
