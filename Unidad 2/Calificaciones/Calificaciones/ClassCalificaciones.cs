using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class ClassCalificaciones
    {
        //Atributos de la clase
      public  int califCapturados = 0, sumaCalif = 0;
        public double promedioGrupal=0; 
     public   int reprobados = 0, aprobados = 0;


        public void contarAprobacion()
        {

            if (califCapturados < 70)
            {
                reprobados++;
            }  
            else
            {
                aprobados++;
            }

            sumaCalif += califCapturados;
            promedioGrupal = sumaCalif / (aprobados + reprobados);

        }
            
       
    }
}            

