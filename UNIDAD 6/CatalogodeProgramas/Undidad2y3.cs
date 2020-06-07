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
    public partial class fmrUndidad2y3 : Form
    {
        public fmrUndidad2y3()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmProgramas frm = new FrmProgramas();

            frm.Show();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Vehiculo.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Embotelladora.exe");
        }

        private void fmrUndidad2y3_Load(object sender, EventArgs e)
        {

        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Temperatura.exe");
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Recibo.exe");
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Personas.exe");
        }

        private void btnMayordeEdad_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/MayorEdad.exe");
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Empleado.exe");
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Cuadrado.exe");
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Concierto.exe");
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Calificaciones.exe");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/MayorEdadExa.exe");
        }
    
    }
}
