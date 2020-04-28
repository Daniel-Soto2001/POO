using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_DocenteAlumnos
{
    public partial class fmrDocente : Form
    {
        //Contador
        int contador = 1;

        //Objeto 
        Docentee Docente = new Docentee();
        public fmrDocente()
        {
            InitializeComponent();

            //Tamaño de los arreglo
            Docente.Nombre = new string[100];
            Docente.Fecha = new DateTime[100];
            Docente.Curp = new string[100];
            Docente.Telefono = new decimal[100];
            Docente.Email = new string[100];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validación del nombre completo
            Regex reNombre = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre completo");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            //Validación de la curp
            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);

            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Ingrese una curp válida");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            //Validación del telefono
            decimal telefono;

            if (!Decimal.TryParse(txtTelefono.Text, out telefono))
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar números en el campo Teléfono");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            //Validación del correo 
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese una dirección de correo");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            //Validación del numero del docente
            Regex reNumDocente = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumDocente.IsMatch(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "Ingrese números en el campo número de docente");
                txtNumero.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero, "");

            //Validación del Sueldo
            decimal sueldo;

            if (!Decimal.TryParse(txtSueldo.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números en el campo sueldo");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (sueldo < 0)
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números positivos");
                txtSueldo.Focus();
                return;
            }

            //Validación de las materias que imparte
            Regex reMImparte = new Regex("[a-zA-ZñÑ/s]", RegexOptions.Compiled);

            if (!reMImparte.IsMatch(txtMaterias.Text))
            {
              errorProvider1.SetError(txtMaterias, "Ingrese una mteria");
                txtMaterias.Focus();
                return;
            }
            errorProvider1.SetError(txtMaterias, "");

            //Condión 
            if (Docente.Nombre.Length != 100)
            { 
                Docente.Nombre[contador] = txtNombre.Text;
                Docente.Fecha[contador] = dtpFecha.Value;
                Docente.Curp[contador] = txtCurp.Text;
                Docente.Telefono[contador] = telefono;
                Docente.Email[contador] = txtEmail.Text;
                Docente.Numero[contador] = int.Parse(txtNumero.Text);
                Docente.Sueldo[contador] = sueldo;
                Docente.MateriasImparte[contador] = txtMaterias.Text;

                //Método para limpiar el textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumero.Clear();
                txtSueldo.Clear();
                txtMaterias.Clear();
            }
            else
            {
                Docente.Nombre = new string[100];
                Docente.Nombre[0] = txtNombre.Text;
                Docente.Fecha= new DateTime[100];
                Docente.Fecha[0] = dtpFecha.Value;
                Docente.Curp = new string[100];
                Docente.Curp[0] = txtCurp.Text;
                Docente.Telefono = new decimal[100];
                Docente.Telefono[0] = telefono;
                Docente.Email = new string[100];
                Docente.Email[0] = txtEmail.Text;
                Docente.Numero = new int[100];
                //Docente.Numero[0] = Convert.ToInt32(txtNumero.Text);
                Docente.Sueldo = new decimal[100];
                Docente.Sueldo[0] = sueldo;
                Docente.MateriasImparte = new string[100];
                Docente.MateriasImparte[0] = txtMaterias.Text;

                //Método para limpiar los textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumero.Clear();
                txtSueldo.Clear();
                txtMaterias.Clear();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Método para limpiar el datagriewView
            dgvDocentes.Rows.Clear();

            for (int i = 0; i < Docente.Nombre.Length; i++)
            {
                if (Docente.Nombre[i] != "" && Docente.Telefono[i] != 0)
                {
                   
                    dgvDocentes.Rows.Add(Docente.Nombre[i], Docente.Fecha[i], Docente.Curp[i], Docente.Telefono[i], Docente.Email[i], Docente.Numero[i], Docente.Sueldo[i], Docente.MateriasImparte[i]);
                }
            }
        }
    }
}
