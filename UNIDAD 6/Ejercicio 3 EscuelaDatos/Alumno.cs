using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_3_EscuelaDatos
{
    public partial class fmrAlumno : Form
    {
        //Variable contador
        int contador = 1;
        //Objeto de la clase Alumnos 
        Alumnos ObjAlumno = new Alumnos();
        TextWriter Ejercicio3;
        public fmrAlumno()
        {
            //Tamaño de los arreglo
            ObjAlumno.Materia = new string[12];
            ObjAlumno.Calificacion = new double[12];
            InitializeComponent();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            //Variable 
            int numerocontrol;

            //Validación de la caja de texto número de control
            if (!int.TryParse(txtControl.Text, out numerocontrol))
            {
                errorProvider1.SetError(txtControl, "Debe ingresar un numero de control");
                txtControl.Focus();
                return;
            }

            //Validación de la cada de texto Carrera
            if (txtCarrera.Text == "")
            {
                errorProvider1.SetError(txtCarrera, "Ingrese en la carrera que estudia");
                txtCarrera.Focus();
                return;
            }
            errorProvider1.SetError(txtCarrera, "");

            //Validación de la cada de texto Materia
            if (txtMateria.Text == "")
            {
                errorProvider1.SetError(txtCarrera, "Introduzca materia");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            //Validación de la cada de texto calificación de la materia
            if (txtMateria.Text == "")
            {
                errorProvider1.SetError(txtCarrera, "Introduzca su calificación");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            if (ObjAlumno.Materia.Length != 12)
            {
                ObjAlumno.Control = numerocontrol;
                ObjAlumno.Carrera = txtCarrera.Text;

             
                ObjAlumno.Materia[contador] = txtMateria.Text;
                ObjAlumno.Calificacion[contador] =Convert.ToInt32(txtSemestre.Text);

                // Limpiar el textbox
                txtMateria.Clear();
                txtMateria.Clear();

                contador++;
            }
            
            else
            {
                ObjAlumno.Control = numerocontrol;
                ObjAlumno.Carrera = txtCarrera.Text;             
                ObjAlumno.Materia = new string[10];

                ObjAlumno.Materia[0] = txtMateria.Text;
                ObjAlumno.Calificacion = new double[10];
                ObjAlumno.Calificacion[0] = int.Parse(txtSemestre.Text);

                //Método para limpiar los textbox
                txtMateria.Clear();
                txtMateria.Clear();
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            //Limpiar datagridview
            dgvAlumno.Rows.Clear();

         
            for (int i = 0; i < ObjAlumno.Materia.Length; i++)

            {
                if (ObjAlumno.Materia[i] != "" && ObjAlumno.Calificacion[i] != 0)
                {
                    
                    dgvAlumno.Rows.Add(ObjAlumno.Materia[i], ObjAlumno.Calificacion[i]);
                }
            }
            Ejercicio3.WriteLine(ObjAlumno.Materia[0]);
            Ejercicio3.WriteLine(txtSemestre.Text);
            Ejercicio3.Close();
        }

        private void fmrAlumno_Load(object sender, EventArgs e)
        {
            Ejercicio3 = new StreamWriter("Alumno.txt");
        }
    }
}

