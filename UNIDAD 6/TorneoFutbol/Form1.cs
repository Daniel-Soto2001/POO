using Microsoft.VisualBasic;
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


namespace TorneoFutbol
{
    public partial class Form1 : Form
    { 
    Torneo objTorneo = new Torneo();
        int Mayor = 0;
        string EquipoGanador="";
        int suma;
        TextWriter Torneo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objTorneo.NombreTorneo = txtNombre.Text;
            objTorneo.NumeroEquipos = (int)nudNumeroEquipos.Value;
            objTorneo.FechaInicio = dtpFechaInicio.Value;
            objTorneo.FechaFin = dtpFechaFin.Value;

            txtNombre.Enabled = false;
            nudNumeroEquipos.Enabled = false;
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
            btnGuardar.Enabled = false;
            nudGanar.Enabled = true;
            nudEmpate.Enabled = true;
            nudPerder.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objTorneo.PuntajesPartido = new string[objTorneo.NumeroEquipos, objTorneo.NumeroEquipos];
            for (int i = 0; i < objTorneo.PuntajesPartido.GetLength(0); i++)
            {
                objTorneo.PuntajesPartido[i, 0] = Interaction.InputBox("Introduce el Nombre del equipo Numero :" + (i + 1));
                for (int j= 1; j< objTorneo.PuntajesPartido.GetLength(1); j++)
                {
                    objTorneo.PuntajesPartido[i, j] = Interaction.InputBox("Introduce el puntaje Obtenido en el partido numero  : " +  j);

                }
            }
            objTorneo.SumaPuntos = new int[objTorneo.NumeroEquipos];
            objTorneo.SumarPuntos();

           
        }

        private void btnCampeon_Click(object sender, EventArgs e)
        {
            objTorneo.SumaPuntos = new int[objTorneo.NumeroEquipos];
            objTorneo.SumarPuntos();

            MessageBox.Show(objTorneo.CalcularGanador(EquipoGanador, Mayor), "Equipo Campeon", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            txtNombre.Enabled = true;
            nudNumeroEquipos.Enabled = true;
            dtpFechaInicio.Enabled = true;
            dtpFechaFin.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombre.Clear();
            nudNumeroEquipos.Value = 1;
            nudGanar.Value = 1;
            nudEmpate.Value = 1;
            nudPerder.Value = 1;

            Torneo.WriteLine(objTorneo.CalcularGanador(EquipoGanador, Mayor));
            Torneo.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Torneo = new StreamWriter("TorneoFutbol.txt");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

