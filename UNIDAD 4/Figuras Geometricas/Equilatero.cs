using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Equilatero : Triangulo
    {
        //Atributos de la clase
     
        private string tipo;
        public string Tipo { get; set; }
        public Equilatero()
        {
            Lado = 0;
        }

        public override void CalcularPerimetro()
        {
            if (Tipo== "Equilatero")
            {
                Perimetro = Lado * 3;
            }
        }
        public override void CalcularArea()
        {
            if (Tipo == "Equilatero")
            {
                Area = (Lado * Altura) / 2;
            }


        }
    }
}
