using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embotelladora
{
    class ClassBotella
    {
        //Atributos de la clase 
      public  int nivelLlenado;
        int mililitrosVerificados;

        //Metodos de la clase
     public  String  verificarLlenado()
        {
            String mensaje;

            if (nivelLlenado == 250)
                mensaje = "Llenado perfecto";
            else if (nivelLlenado < 250)

            {
                mililitrosVerificados = 250 - nivelLlenado;
                mensaje = " Le faltan " + mililitrosVerificados + " mililitros";              
            }
            else
            {
                mililitrosVerificados = nivelLlenado - 250;
                mensaje = " Le sobra " + mililitrosVerificados + " mililitros";
            }
            return mensaje ;
        }

    }

}
