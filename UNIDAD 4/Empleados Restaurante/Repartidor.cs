using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class Repartidor:Empleado
    {
        //Atributos de la clase
        private double propinasemanal;
        private string zonareparto;
        private int abonos;

        public double Propinasemanal { get; set; }
        public string Zonareparto { get; set; }
        public int Abonos { get; set; }

        public Repartidor()
        {
            Propinasemanal = 0;
            Zonareparto = "";
            Abonos = 0;
        }
        public override void Calcularsueldo()
        {
            switch(Zonareparto)
            {
                case "Zona 1":
                    Salariosemanal = (Sueldo*Diastrabajados);
                    Salariosemanal = Salariosemanal + (Abonos * 5);
                   


                    break;
                case "Zona 2":
                    Salariosemanal = Sueldo * Diastrabajados;
                    Salariosemanal = Salariosemanal + (Abonos * 2);
                    break;
            }
        }

    }
}
