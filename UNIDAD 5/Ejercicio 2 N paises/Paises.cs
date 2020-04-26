using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_N_paises
{
    class Paises
    {
        //Variables
        private string pais;
        private int poblacion;
        private string idioma;

        //Propiedades
        public string Pais { get; set; }
        public int Poblacion { get; set; }
        public string Idioma { get; set; }

        //Array
        public string[] Colores;
       

        //Constructor
        public Paises()
        {
            Pais = "";
            Poblacion = 0;
            Idioma = "";
          
        }
        
    }
}
