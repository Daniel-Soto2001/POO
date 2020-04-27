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
    public partial class fmrAlumno : Form
    {
        //Contador
        int contador = 1;

        //Objeto d
        Alumnoo Alumno = new Alumnoo();
        public fmrAlumno()
        {
            //Tamaño de los arreglo
            Alumno.Nombre = new string[100];
            Alumno.Fecha = new DateTime[100];
            Alumno.Curp = new string[100];
            Alumno.Telefono = new decimal[100];
            Alumno.Email = new string[100];
            Alumno.Control = new int[100];
            Alumno.Carrera = new string[100];
            Alumno.Materias = new string[100];
            Alumno.Calificacion = new double[100];
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validación para el nombre
            Regex reNombre = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            //Validación para la curp
            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);

            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Ingrese una curp ");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            //Validación para el telefono
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
                errorProvider1.SetError(txtEmail, "Ingrese una dirección de correo válida");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            //Validación del número de control
            Regex reNumControl = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumControl.IsMatch(txtControl.Text))
            {
                errorProvider1.SetError(txtControl, "Ingrese números en el campo número de control");
                txtControl.Focus();
                return;
            }
            errorProvider1.SetError(txtControl, "");

            //Validación de la Carrera
            Regex reCarrera = new Regex("[a-zA-ZñÑ/s]", RegexOptions.Compiled);

            if (!reCarrera.IsMatch(txtCarrera.Text))
            {
                errorProvider1.SetError(txtCarrera, "Ingrese una carrera válida");
                txtCarrera.Focus();
                return;
            }
            errorProvider1.SetError(txtCarrera, "");

            //Validación de las Materia
            Regex reMateria = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reMateria.IsMatch(txtMateria.Text))
            {
                errorProvider1.SetError(txtMateria, "Ingrese una materia");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            //Validación de las calificaciones de las materias
            Regex reCalificacion = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (txtMateria.Text == "")
            {
                errorProvider1.SetError(txtMateria, "Ingrese una calificación válida");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            //Condión 
            if (Alumno.Nombre.Length != 100)
            {

                Alumno.Nombre[contador] = txtNombre.Text;
                Alumno.Fecha[contador] = dtpFecha.Value;
                Alumno.Curp[contador] = txtCurp.Text;
                Alumno.Telefono[contador] = telefono;
                Alumno.Email[contador] = txtEmail.Text;
                Alumno.Control[contador] = int.Parse(txtControl.Text);
                Alumno.Carrera[contador] = txtCarrera.Text;
                Alumno.Materias[contador] = txtMateria.Text;
                Alumno.Calificacion[contador] = double.Parse(txtMateria.Text);

                //Método para limpiar el textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtControl.Clear();
                txtCarrera.Clear();
                txtMateria.Clear();
                txtMateria.Clear();
            
                contador++;
            }
            //Sino se cumple 
            else
            {
                Alumno.Nombre = new string[100];              
                Alumno.Nombre[0] = txtNombre.Text;
                Alumno.Fecha= new DateTime[100];
                Alumno.Fecha[0] = dtpFecha.Value;
                Alumno.Curp = new string[100];
                Alumno.Curp[0] = txtCurp.Text;
                Alumno.Telefono = new decimal[100];
                Alumno.Telefono[0] = telefono;
                Alumno.Email = new string[100];
                Alumno.Email[0] = txtEmail.Text;
                Alumno.Control = new int[100];
                Alumno.Control[0] = int.Parse(txtControl.Text);
                Alumno.Carrera = new string[100];
                Alumno.Carrera[0] = txtCarrera.Text;
                Alumno.Materias = new string[100];
                Alumno.Materias[0] = txtMateria.Text;
                Alumno.Calificacion = new double[100];
                Alumno.Calificacion[0] = int.Parse(txtMateriaa.Text);

                //Método para limpiar los textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtControl.Clear();
                txtCarrera.Clear();
                txtMateria.Clear();
                txtMateria.Clear();
            
        }
    }

        private void btnImprimir_Click(object sender, EventArgs e)
        { 
            //Limpiador del datagridview
            dgvAlumno.Rows.Clear();

            for (int i = 0; i < Alumno.Nombre.Length; i++)
            {
                if (Alumno.Nombre[i] != "" && Alumno.Telefono[i] != 0)
                {
                    dgvAlumno.Rows.Add(Alumno.Nombre[i], Alumno.Fecha[i], Alumno.Curp[i], Alumno.Telefono[i], Alumno.Email[i], Alumno.Control[i], Alumno.Carrera[i], Alumno.Materias[i], Alumno.Calificacion[i]);
                }
            }
        }
    }
}
