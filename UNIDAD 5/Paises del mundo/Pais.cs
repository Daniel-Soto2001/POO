
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paises_del_mundo
{
    class Pais
    {
        //Variables
        private string nombrepais;
        private int poblacion;
        private string idioma;
        private string colores;

        //Propiedades
        public string NombrePais { get; set; }
        public int Poblacion { get; set; }
        public string Idioma { get; set; }
        public string Colores { get; set; }

        //Arreglo
        public string[] ColoresPais;

        //Constructor
        public Pais()
        {
            NombrePais = "";
            Poblacion = 0;
            Idioma = "";
            Colores = "";
        }
    
       
            
        
    }
}
