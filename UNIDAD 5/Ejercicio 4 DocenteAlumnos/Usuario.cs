using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_DocenteAlumnos
{
    public partial class fmrUsuario : Form
    {
        int contador = 1;
        Alumnoo ObjAlumno = new Alumnoo();
        Docentee ObjDocente = new Docentee();
        public fmrUsuario()
        {
            InitializeComponent();

            ObjAlumno.Usuario = new string[100];
            ObjDocente.Usuario = new string[100];
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (ObjAlumno.Usuario.Length != 100)
            {
                if (cmbPersona.Text == "Alumno")
                {
                    ObjAlumno.Usuario[contador] = cmbPersona.Text;

                    fmrAlumno Alumno = new fmrAlumno();
                   Alumno.Show();
                }
                else if (cmbPersona.Text == "Docente")
                {
                    ObjDocente.Usuario[contador] = cmbPersona.Text;

                    fmrDocente Docente = new fmrDocente();
                    Docente.Show();
                }
                contador++;
            }
            else
            {
                if (cmbPersona.Text == "Alumno")
                {
                    ObjAlumno.Usuario = new string[100];
            
                    ObjAlumno.Usuario[0] = cmbPersona.Text;

                   
                    fmrAlumno Alumno = new fmrAlumno();
                    Alumno.Show();
                }
                else if (cmbPersona.Text == "Docente")
                {
                    ObjDocente.Usuario = new string[100];
                   
                    ObjDocente.Usuario[0] = cmbPersona.Text;

                    
                    fmrDocente Docente = new fmrDocente();
                    Docente.Show();
                }
            }

        }
    }
}
