using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    class Convertidora : MonedaDeCambio
    {
        private int dolar;
        private int pesos;

        public int Dolar { get; set; }
        public int Pesos { get; set; }

        public Convertidora()
        {
            Dolar = 0;
            Pesos = 0;
        }
        public void PesosaDolar()
        {

             Pesos = Dolar * 24;
        }

    
    }
    
}

