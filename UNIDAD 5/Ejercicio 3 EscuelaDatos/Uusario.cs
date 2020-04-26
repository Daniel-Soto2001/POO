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

namespace Ejercicio_3_EscuelaDatos
{
    public partial class fmrUsuario : Form
    {
        Alumnos ObjAlumno = new Alumnos();
        Docentee ObjDocente = new Docentee();
       


        public fmrUsuario()
        {
            InitializeComponent();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

         
            

            int telefono;
            if (!int.TryParse(txtTelefono.Text, out telefono))
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar un numero de telefono");
                txtTelefono.Focus();
                return;
            }

            if (telefono < 0)
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar un numero positivo");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                      + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                      + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                      + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                      + @"[a-zA-Z]{2,}))$",
                                      RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Debe ingresar una direccion de correo valida");
                txtEmail.Focus();
            }
            errorProvider1.SetError(txtEmail, "");


      
          
                if (ckbAlumno.Enabled == true)
                {
                fmrAlumno Alumno = new fmrAlumno();
                Alumno.Show();

                ObjAlumno.Nombre = txtNombre.Text;
                ObjAlumno.Fecha = dtpFecha.Value;
                ObjAlumno.Curp = txtCurp.Text;
                ObjAlumno.Telefono = telefono;
                ObjAlumno.email = txtEmail.Text;
                ObjAlumno.Usuarioo = ckbAlumno.Text;
            }

                if (ckbDocente.Checked == true)
                {
                    fmrDocente Docente = new fmrDocente();
                    Docente.Show();
                ObjDocente.Nombre = txtNombre.Text;
                ObjDocente.Fecha = dtpFecha.Value;
                ObjDocente.Curp = txtCurp.Text;
                ObjDocente.Telefono = telefono;
                ObjDocente.email = txtEmail.Text;
            }
            }

        private void fmrUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
