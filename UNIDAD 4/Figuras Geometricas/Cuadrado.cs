using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Cuadrado:Figura
    {
  
        public override void CalcularPerimetro()
        {
            Perimetro = Lado + Lado + Lado + Lado;
        }
        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }
        
        
        
        
        
        
        
        
        
        
             
    }
}
