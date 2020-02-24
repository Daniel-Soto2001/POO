using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_edad
{
    class ClassPersona
    {
        //Atributo de la clase
        public int dianacimiento = 0, mesnacimiento = 0, anonacimiento = 0;       
        public int diaactual = 0, mesactual = 0, anoactual = 0;
        public string MayordeEdad;
        //Metodos de la clase
        public void Mayor()
        {
            if (anoactual - anonacimiento > 18)
            {
                MayordeEdad = "Es mayor de edad";
            }
            else if (anoactual-anonacimiento==18)
            {
                if (mesactual>mesnacimiento)
                {
                    MayordeEdad = "Es mayor de edad";
                }
                else if (mesactual==mesnacimiento)
                {
                    if (diaactual>dianacimiento)
                    {
                        MayordeEdad = "Es mayor de edad";
                    }
                    else if(diaactual==dianacimiento)
                    {
                        MayordeEdad = "Es mayor de edad";
                    }
                }


            }









         }
















    }
}
