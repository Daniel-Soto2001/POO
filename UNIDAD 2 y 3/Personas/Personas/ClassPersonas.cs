using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class ClassPersonas
    {
        //Atributos de la clase
        public string nayarit;
        public string tipo;
        public int naayarit = 0, fechascapturadas;
        public int contadornayarit = 0;
        public int contadormayor = 0;
        public int contadortipo = 0;
        public int Alumno = 0, Maestro = 0, Administrador = 0;
        //Metodos de la clase
        public void Estados()
        {
            switch (nayarit)
            {
                default:
                    naayarit = naayarit + contadornayarit;
                    break;
            }

            if (fechascapturadas > 2002)
            {
                contadormayor++;
            }
        }
            
        public void Tipos()
        {
            switch (tipo)
            {
                case "Alumno":
                    Alumno = Alumno + contadortipo;
                    break;
                case "Maestro":
                    Maestro = Maestro + contadortipo;
                    break;
                case "Administrador":
                    Administrador = Administrador + contadortipo;
                    break;
            }
        

        }
        
        
        
        
        
        
        
    
    }
}
