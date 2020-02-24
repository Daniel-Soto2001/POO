using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class ClassVehiculo
    {
        //Atributos de la clase
        public int resu;
        public string cuota;
        //Metodos de la clase
        public void Caseta()
        {
            switch(cuota)
            {
                case "Motociclista":
                  resu= 50;
                    break;
                case "Automovil":
                    resu = 112;
                    break;
                case "Autobus":
                    resu = 170;
                    break;
                case "Trailer":
                    resu =  250;
                    break;
            }
        }
        
        
         
    }
}
