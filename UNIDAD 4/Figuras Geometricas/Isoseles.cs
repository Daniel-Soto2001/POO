using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Isoseles : Triangulo
    {
        private double lado2;
        private string tipo;
        public double Lado2 { get; set; }
        public double Altura { get;  set; }
        public string Tipo { get; set; }
     
        public Isoseles()
        {
            Lado = 0;
            Lado2 = 0;
        }
        public override void CalcularPerimetro()
        {
            if(Tipo=="Isoseles")
            {
                Perimetro = (Lado * 2) + Lado2;
            }
        }
        public override void CalcularArea()
        {
         if(Tipo=="Isoseles")
            {
                Area = (Lado * Altura);
            }
        }

    }
}







    