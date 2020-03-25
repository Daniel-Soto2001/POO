using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanza
{
    class ClaseFacil:Juego
    {
        
        
        public override void CalcularNumero()
        {
            if (NumeroIntroducir == NumeroGanador)
            {
                Resultado = "Has adivinado el numero !Felicidades has ganado!";
                ResultadoOpcion = "Has ganado 100 puntos";
            }
            else
            {
                Resultado = "No haz adivinado el numero !Perdiste sigue intentando !";
                ResultadoOpcion = "Has peridido 100 puntos";
            }

        }




    }
}
