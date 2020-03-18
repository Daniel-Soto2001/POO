using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class Cajero : Empleado
    {
        private double caja;
        private int numcaja;
        public string cajas;


        public double Caja { get; set; }
        public int Numcaja { get; set; }
        public string Cajas { get; set; }
        public Cajero()
        {
            Caja = 0;
            Numcaja = 0;

        }
        public override void Calcularsueldo()
        {
            switch (Cajas)
            {
                case "Caja 1":
                    Salariosemanal = Sueldo * Diastrabajados;
                    break;
                case "Caja 2":
                    Salariosemanal = Sueldo * Diastrabajados;
                    Salariosemanal = Salariosemanal + (0.3) * Salariosemanal;
                    break;           
            }
        }
    } 
    }
     
            
    

    

