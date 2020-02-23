using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class ClassCuadrado
    {
        //Atributos de la clase
    public int lado=0;
        public int per;
        public int are;
       
        //Metodos de la clase
        public void PerimetroyArea()
        {
            per = lado + lado + lado + lado;
            are = lado * lado;
        }
        

    }
}
