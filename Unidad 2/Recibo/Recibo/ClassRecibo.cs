using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo
{
    class ClassRecibo
    {
        //Atributos de la clase
        public double kilo = 0;
        public double resukilo = 0;
        public double resunego = 0;      
        //Metodos de la clase
        public void KilowattsHogar()
        {
            if (kilo <= 0 & kilo >= 250)
            {
                resukilo = kilo * 0.65;
            }
            else if (kilo <= 251 & kilo >= 500)
            {
                resukilo = kilo * 0.85;
            }
            else if (kilo <= 501 & kilo >= 1200)
            {
                resukilo = kilo * 1.5;
            }
            else if (kilo <= 1201 & kilo >= 2100)
            {
                resukilo = kilo * 2.5;
            }
            else if (kilo>=2101)
            {
                resukilo = kilo * 3;
            }
                
        }
        public void KilowattsNegocio()
        {
            if(kilo>=0)
            {
                resunego = kilo * 5;
            }

        }
            












    }
}
