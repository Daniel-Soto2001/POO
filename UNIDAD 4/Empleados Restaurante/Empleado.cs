using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
   abstract class Empleado
    {
        //Atributos de la clase
        private string nombre;
        private string fechanacimiento;
        private int diastrabajdos;
        private double sueldo;
        private double salariosemanal;
        private int anoactu;
        private int mesactu;
        private int diaactu;
        private int anonac;
        private int mesact;
        private int diaact;
        

        public string Nombre { get; set; }
        public string Fechanacimiento { get; set; }
        public int Diastrabajados { get; set; }
        public double Sueldo { get; set; }
        public double Salariosemanal { get; set; }
        public int Anoactu { get; set; }
        public int Mesactu { get; set; }
        public int Diaactu { get; set; }
        public int Anonac { get; set; }
        public int Mesnac { get; set; }
        public int Dianac { get; set; }
        public Empleado()
        {
            Nombre = "";
            Fechanacimiento = "";
            Diastrabajados = 0;
            Sueldo = 0;
            Salariosemanal = 0;
            Anoactu = 0;
            Mesactu = 0;
            Diaactu = 0;
            Anonac = 0;
            Mesnac = 0;
            Dianac = 0;
        }

        public abstract void Calcularsueldo();
        

        





    }
}
