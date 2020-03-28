using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanza
{
    interface Numeros
    {
         int NumeroIntroducir { get; set; }
         int NumeroGanador { get; set; }
         string Resultado { get; set; }
         string ResultadoOpcion { get; set; }

        void  CalcularNumero();
    }
}
