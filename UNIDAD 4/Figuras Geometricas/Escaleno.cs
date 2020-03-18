using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Escaleno:Triangulo
    {
        //Atributos de la clase
       
        private double lado2;
        private double lado3;
        private string tipo;
     
       
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public string Tipo { get; set; }
     

        public Escaleno()
        {
            
            Lado2 = 0;
            lado3 = 0;
        }
        public override void CalcularPerimetro()
        {
            if(Tipo=="Escaleno")
            {
                Perimetro = Lado + Lado2 + Lado3;
            }
        }
            public override void CalcularArea()
        {
         if(Tipo=="Escaleno")
            {
                Area = (Lado * Altura) / 2;
            }



        }








    }
}
