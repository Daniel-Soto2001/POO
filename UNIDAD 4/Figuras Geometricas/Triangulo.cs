using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    abstract class Triangulo : Figura
    {

        //Atributos de la clase
        private double altura;
        

        public double Altura { get; set; }
        public double Lado2 { get; internal set; }
        public double Lado3 { get; internal set; }

        public Triangulo()
        {
            Altura = 0;
            
        }
        public override void CalcularPerimetro()
        {
            
        }
        public override void CalcularArea()
        {
          
        }



    }
}  

