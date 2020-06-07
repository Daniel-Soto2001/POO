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
    public partial class fmrUnidad1 : Form
    {
        public fmrUnidad1()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

           FrmProgramas frm = new FrmProgramas();

            frm.Show();
        }

        private void btnMiPrimerProyectoWindowsForms1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/MiPrimerProyectoWindowsForms1.exe");
        }

        private void btnProyecto1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Daniel\Desktop\POO\UNIDAD 6\Programas/Proyecto1.exe");
        }
    }
}
