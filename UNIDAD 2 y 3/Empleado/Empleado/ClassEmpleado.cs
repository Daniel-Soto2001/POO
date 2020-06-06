using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    class ClassEmpleado
    {
        //Atributos de la clase
        public int anos = 0;
        public int dias = 0;
        //Metodos de la clase
        public void Vacaciones()
        {
            if (anos >= 1 & anos <= 5)
            {
                dias = 5;
            }
            else if (anos >= 6 & anos <= 10) 
            {
                dias = 10;
            }
            
            else if (anos > 10 & anos < 20)
            {
                dias = (anos-10)+10;
            }
            else if (anos >= 20 & anos <= 32)
            {
                dias = (anos-10)*2;
            }


        }







    



    }
}
