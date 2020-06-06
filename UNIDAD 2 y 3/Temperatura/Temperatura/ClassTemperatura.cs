using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class ClassTemperatura
    {
        //Atributos de la clase
        public int grados;
        public double celsius=0;
        public double fahrenheit=0;
        public string ingresagrados;
        //Metodos de la clase
        public void Grados()
        {
            switch(ingresagrados)
            {
                case "Celsius":
                    celsius = (grados * 1.8000) + 32;
                    break;
                case "Fahrenheit":
                    fahrenheit = (grados - 32) / 1.8000;
                    break;



            }
        }




    }
}
