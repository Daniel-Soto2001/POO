using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogodeProgramas
{
    public partial class FrmProgramas : Form
    {
        public FrmProgramas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"POO.jpg");
            this.BackgroundImage = img;
        }

        private void btnUnidad1_Click(object sender, EventArgs e)
        {
            fmrUnidad1  frm = new fmrUnidad1();

            frm.Show();

            this.Hide();
        }

        private void btnUnidad2y3_Click(object sender, EventArgs e)
        {
          fmrUndidad2y3   frm = new fmrUndidad2y3();

            frm.Show();

            this.Hide();
        }

        private void btnUnidad4_Click(object sender, EventArgs e)
        {
            fmrUnidad4 frm = new fmrUnidad4();

            frm.Show();

            this.Hide();
        }

        private void btnUnidad5_Click(object sender, EventArgs e)
        {
            fmrUnidad5 frm = new fmrUnidad5();

            frm.Show();

            this.Hide();
        }

        private void btnUnidad6_Click(object sender, EventArgs e)
        {
            fmrUnidad6 frm = new fmrUnidad6();

            frm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
