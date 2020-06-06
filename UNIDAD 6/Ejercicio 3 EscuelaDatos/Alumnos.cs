using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_EscuelaDatos
{
    class Alumnos:Usuario
    {
        //Propiedades 
        public int Control { set; get; }
        public string Carrera { set; get; }
        public string[] Materia;
        public double[] Calificacion;
    }
}
