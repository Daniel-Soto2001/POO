using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorEdad
{
    class ClassPersona
    {
        //Atributos de la clase
        public int anoActual, MesActual, DiaActual;
        public int anoNacimiento, MesNacimiento, DiaNacimiento;
        public string MayorEdad="";
        public string MenorEdad = "";
       
        //Metodos de la clase
        public void MayordeEdad()
        {
            if (anoActual - anoNacimiento > 18)
            {
                MayorEdad = "Es mayor de Edad";
                MenorEdad = "Es menor de Edad";

            }
            else if (anoActual - anoNacimiento == 18)
            {
                if (MesActual > MesNacimiento)
                {
                    MayorEdad = "Es mayor de Edad";
                }

                else if (MesActual == MesNacimiento)
                {
                    if (DiaActual > DiaNacimiento)
                    {
                        MayorEdad = "Es mayor de Edad";
                    }
                    else if(DiaActual==DiaNacimiento)
                    {
                        MayorEdad = "Es mayor de Edad";
                    }
                }
            }



            

          }
        }
    }
