using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanza
{
    class ClaseDificil:Juego
    {
        public override void CalcularNumero()
        {
            if (NumeroIntroducir == NumeroGanador)
            {
                Resultado = "Has adivinado el numero !Felicidades has ganado!";
                ResultadoOpcion = "Has ganado 1000 puntos";
            }
            else
            {
               Resultado = "No has adivinado el numero !Perdiste sigue intentando !";
                ResultadoOpcion = "Has perdido 1000 puntos";
            }

        }
    }
}
