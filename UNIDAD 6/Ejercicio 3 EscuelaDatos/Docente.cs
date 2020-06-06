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
    public partial class fmrDocente : Form
    {
        //Contador  
        int contador = 1;
        //Objeto de la clase Docentes 
        Docentee ObjDocente = new Docentee();
        TextWriter Docente;

        public fmrDocente()
        {
            
                //Tamaño del arreglo
                ObjDocente.MateriasImparte = new string[12];
                InitializeComponent();
                
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
          int numerodocente;

            //Validación de la caja de texto número del docente
            if (!int.TryParse(txtNumero.Text, out numerodocente))
            {
                errorProvider1.SetError(txtNumero, "Debe ingresar una cantidad");
                txtNumero.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero, "");

            int sueldo;
            //Validación de la cada de texto Sueldo
            if (!int.TryParse(txtSueldo.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Debe ingresar una cantidad sueldo");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (sueldo < 0)
            {
                errorProvider1.SetError(txtSueldo, "Debe ingresar números positivos");
                txtSueldo.Focus();
                return;
            }

            //Validación de la caja de texto materias que imparte
            if (txtMaterias.Text == "")
            {
                errorProvider1.SetError(txtMaterias, "Introduzca materias que imparte");
                txtMaterias.Focus();
                return;
            }
            errorProvider1.SetError(txtMaterias, "");

         
            if (ObjDocente.MateriasImparte.Length != 12)
            {
                ObjDocente.Numero = numerodocente;
                ObjDocente.Sueldo = sueldo;
             
                ObjDocente.MateriasImparte[contador] = txtMaterias.Text;

                //Limpiar el textbox 
                txtMaterias.Clear();
              
                contador++;
            }
           
            else
            {
                ObjDocente.Numero = numerodocente;
                ObjDocente.Sueldo = sueldo;
                ObjDocente.MateriasImparte = new string[10];
                //Se indica la posición del arreglo
                ObjDocente.MateriasImparte[0] = txtMaterias.Text;

                //Método para limpiar el textbox
                txtMaterias.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiar datagridview
            dgvDocente.Rows.Clear();

           
            for (int i = 0; i < ObjDocente.MateriasImparte.Length; i++)
            {
                
                if (ObjDocente.MateriasImparte[i] != "")
                {
                    
                    dgvDocente.Rows.Add(ObjDocente.MateriasImparte[i]);
                }
            }
            Docente.WriteLine(ObjDocente.MateriasImparte[0]);
            Docente.Close();
        }

        private void fmrDocente_Load(object sender, EventArgs e)
        {
            Docente = new StreamWriter("Docente.txt");
        }

        private void txtMaterias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
