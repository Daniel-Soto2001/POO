using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class ClassVehiculo
    {
        //Atributos de la clase
        public  string TipoCombustible, color, arrancar, parar ;
        public int NumeroLlantas;
        public int NumeroPuertas;
        public int NumeroVentanas;
        
     //Constructor de la clase se llama igual de la clase y se ejecuta automaticamente al craer el objeto
        public ClassVehiculo()
        {
            TipoCombustible = "";
            color = "Blanco";
            NumeroLlantas = 1;
            NumeroPuertas = 0;
            NumeroVentanas = 0;

        }
        public string ArrancarMotor ()
        {
           arrancar = " (Run Run Run) ";
            return "Se arrancó el motor" + arrancar;
        }

        public string PararMotor ()
        {
            parar = " (Prrrrrrrrr) ";
            return "Se paro el motor" + parar;
        }




    } 
}
