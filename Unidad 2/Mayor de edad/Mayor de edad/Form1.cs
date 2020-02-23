using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayor_de_edad
{
    public partial class Form1 : Form
    {
        ClassPersona objpersona = new ClassPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objpersona.anoactual = int.Parse(DateTime.Today.Year.ToString());
            objpersona.mesactual = int.Parse(DateTime.Today.Month.ToString());
            objpersona.diaactual = int.Parse(DateTime.Today.Day.ToString());
            objpersona.anonacimiento = int.Parse(dateTimePicker1.Value.Year.ToString());
            objpersona.mesnacimiento = int.Parse(dateTimePicker1.Value.Month.ToString());
            objpersona.dianacimiento = int.Parse(dateTimePicker1.Value.Day.ToString());
            objpersona.Mayor();
            lblMayor.Text = objpersona.MayordeEdad;
            objpersona.MayordeEdad = "";
        }
    }
}
