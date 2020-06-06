using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_EscuelaDatos
{
    class Docentee:Usuario
    {
        //Propiedades 
        public decimal Numero { set; get; }
        public decimal Sueldo { set; get; }
        public string[] MateriasImparte;
    }
}
