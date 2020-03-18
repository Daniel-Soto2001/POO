using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class Mesero : Empleado
    {
        //Atributos de la clase
        private double propina;
        private string salario;
        private double propinasemanal;

        public double Propina { get; set; }
        public string Salario { get; set; }
        public double Propinasemanal { get; set; }
        public Mesero()
        {
            Propina = 0;
            Propinasemanal = 0;
        }
        public override void Calcularsueldo()
        {
            switch (Salario)
            {
                case "1":
                    Salariosemanal = (Sueldo * 1) + Propinasemanal;
                    break;
                case "2":
                    Salariosemanal = (Sueldo * 2) + Propinasemanal;
                    break;
                case "3":
                    Salariosemanal = (Sueldo * 3) + Propinasemanal;
                    break;
                case "4":
                    Salariosemanal = (Sueldo * 4) + Propinasemanal;
                    break;
                case "5":
                    Salariosemanal = (Sueldo * 5) + Propinasemanal;
                    break;
                case "6":
                    Salariosemanal = (Sueldo * 6) + Propinasemanal;
                    break;
                case "7":
                    Salariosemanal = (Sueldo * 7) + Propinasemanal;
                    break;

            }
        }
    }
}
