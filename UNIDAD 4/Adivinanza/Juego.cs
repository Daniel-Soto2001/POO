using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanza
{
  abstract class Juego:Numeros
    {
        //Atributod de la clase
        private int numeroganador;
        private string resultado;
        private int numerointroducir;
        private string resultadoopcion;
        
        //Propiedades
        public int NumeroIntroducir { get; set; }
        public int NumeroGanador { get; set; }
        public string Resultado { get; set; }
        public string ResultadoOpcion { get; set; }
            

        public Juego()
        {
            NumeroGanador = 0;
            NumeroIntroducir = 0;
            Resultado = "";
            ResultadoOpcion = "";
        }
        public abstract void CalcularNumero();



    }
}
