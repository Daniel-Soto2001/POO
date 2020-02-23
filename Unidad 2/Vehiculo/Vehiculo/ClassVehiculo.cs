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
        public int Automovil = 0, Motociclista = 0, Autobus = 0, Trailer = 0;
        public string cuota;
        //Metodos de la clase
        public void Caseta()
        {
            switch(cuota)
            {
                case "Motociclista":
                    Motociclista = Motociclista + 50;
                    break;
                case "Automovil":
                    Automovil = Automovil + 112;
                    break;
                case "Autobus":
                    Autobus = Autobus + 170;
                    break;
                case "Trailer":
                    Trailer = Trailer + 250;
                    break;
            }
        }
        
        
         
    }
}
