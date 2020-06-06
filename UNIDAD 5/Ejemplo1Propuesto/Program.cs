using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1Propuesto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arreglo es como una coleccion de datos ya sean se un mismo tipo o diversos tipos
            int n;
            int suma = 0;
            double promedio;
            //Arreglo Inicializado
            int[] calificaciones = { 0, 2, 4, 6, 8, 10, 1, 3, 5, 7, 9 };
            string[] alumnos = { "Ismael", "Javier", "Ignacio", "Marcelo", "Rodrigo", "Mariana", "Belen", "Aranza", "Luis", "Daniel", "Maricela" };
            //Matriz
            for (n = 0; n < calificaciones.Length; n++)
            {
                Console.WriteLine("La califiacion de {0} es: {1}", alumnos[n], calificaciones[n]);
                //Matriz
            }
                for (n = 0; n < calificaciones.Length; n++)
                {
                    suma = suma + calificaciones[n];
                }
                promedio = suma / calificaciones.Length;
                Console.WriteLine("--------");
                Console.WriteLine("La suma de las calificaciones es: {0}", suma);
                Console.WriteLine("El promedio de los alumnos es: {0}", promedio);

                Console.ReadLine();
            }
        
    }
}
