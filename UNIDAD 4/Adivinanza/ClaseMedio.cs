using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanza
{
    class ClaseMedio:Juego
    {

        public override void CalcularNumero()
        {
            if (NumeroIntroducir == NumeroGanador)
            {
                Resultado = "Haz adivinado el numero !Felicidades has ganado!";
                ResultadoOpcion = "Has ganado 500 puntos";
            }
            else
            {
                Resultado = "No haz adivinado el numero !Perdiste sigue intentando !";
                ResultadoOpcion = "Has perdido 100 puntos";
            }
        }
     
        
    }
}
