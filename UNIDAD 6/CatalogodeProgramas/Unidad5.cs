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
    public partial class fmrUnidad5 : Form
    {
        public fmrUnidad5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmProgramas frm = new FrmProgramas();

            frm.Show();
        }

        private void btnClase_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/MiPrimeraClase.exe");
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Paises del mundo.exe");
        
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejercicio 2 N paises.exe");

        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejercicio 3 EscuelaDatos.exe");

        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejercicio 4 DocenteAlumnos.exe");

        }

        private void btnEjemplo1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Ejemplo1Propuesto.exe");

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/MatrizSumaFCD.exe");

        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/NumeroMayorMenor.exe");

        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 5\TorneoFutbol\bin\Debug/TorneoFutbol");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBidi1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Bidimensional1.exe");

        }

        private void btnBidi2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Bidimensional2.exe");
        }

        private void btnBidi3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Bidimensional3.exe");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Calcularadora.exe");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
