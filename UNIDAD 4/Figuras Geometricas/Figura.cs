using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
     abstract class Figura
    {
        //Atributos de la clase
        private double lado;
        private double perimetro;
        private double area;

        public double Lado { get; set; }
        public double Perimetro { get; set; }
        public double Area { get; set; }
        
        public Figura()
        {
            Lado = 0;
            Perimetro = 0;
            Area = 0;
        }

        public abstract void CalcularPerimetro();




        public abstract void CalcularArea();
        

        


















    
    }
}
