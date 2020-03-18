using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class ClassAereo:ClassVehiculo
    {
        //Atributos de la clase
        public int NumTurbinas, NumAlas, NumHelices;
        public string TipoAereo, Estado;

        public ClassAereo()
        {
            NumAlas = 0;
            NumTurbinas = 0;
            NumHelices = 0;
            TipoAereo = "";
        }
        public string enVuelo ()
        {
            Estado = "Volando";
            return "El   "  +  TipoAereo  + " esta " + Estado; 
        }




    }
}
