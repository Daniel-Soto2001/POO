using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_List
{
    public partial class Form1 : Form
    {
        ArrayList Personas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona Persona1 = new Persona();
            Persona1.ID = "1010";
            Persona1.Nombres = "Lady";
            Persona1.Apellidos = "Gaga";
            Persona1.Correo = "LadyGaga@gmail.com";
            Persona1.FechaNacimiento = new DateTime(1990, 3, 14);
            Persona1.Salario = 1200000;
            Personas.Add(Persona1);

            Persona Persona2 = new Persona();
            Persona2.ID = "2020";
            Persona2.Nombres = "Dady";
            Persona2.Apellidos = "Yankie";
            Persona2.Correo = "Dady@yahoo.es";
            Persona2.FechaNacimiento = new DateTime(1987,7,20);
            Persona2.Salario = 2560000;
            Personas.Add(Persona2);

            dgvDatos.DataSource = Personas;





        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if (txtID.Text=="")
            {
                errorProvider1.SetError(txtID, "Debe ingresar un ID de la persona");             
                txtID.Focus();
                return;

            }
            errorProvider1.SetError(txtID, "");
            if(Existe(txtID.Text))
            {
                errorProvider1.SetError(txtID, "ID de empleado ya ha sido registrado");
                txtID.Focus();
                return;
            }

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar nombre(s) de la persona");
                txtNombres.Focus();
                return;

            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar apellido(s) de la persona");
                txtApellidos.Focus();
                return;

            }
            errorProvider1.SetError(txtApellidos, "");

            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                       + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                       + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                       + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                       + @"[a-zA-Z]{2,}))$",
                                       RegexOptions.Compiled);

            if(!regEmail.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar una direccion de correo valida");
                txtCorreo.Focus();
            }
            errorProvider1.SetError(txtCorreo, "");

            decimal Salario;
            if (!Decimal.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar numeros en el campo salario");
                txtSalario.Focus();
                return;
            }

            if (Salario<0)
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar un numero positivo");
                txtSalario.Focus();
                return;
            }

            Persona miPersona = new Persona();
            miPersona.ID = txtID.Text;
            miPersona.Nombres = txtNombres.Text;
            miPersona.Apellidos = txtApellidos.Text;
            miPersona.Correo = txtCorreo.Text;
            miPersona.FechaNacimiento = dtpNacimiento.Value;
            miPersona.Salario = Salario;
            Personas.Add(miPersona);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;

            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtID.Focus();

        }

        private bool Existe(string ID)
        {
           foreach(Persona Persona in Personas)
            {
                if (Persona.ID == ID) return true;
            }
            return false;
        }
    }
}
