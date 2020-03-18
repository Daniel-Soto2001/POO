using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Circulo:Figura
    {
        //Atributos de la clase
        private double pi= 3.14;
        private float radio;

        public float Pi { get; set; }
        public float Radio { get; set; }
       

        public override void CalcularPerimetro()
        {
            Perimetro =(Lado*Lado)*3.14;
        }

        public override void CalcularArea()
        {
            Area = 3.14 * (Lado) * 3.14 * (Lado);
        }




    }
}
