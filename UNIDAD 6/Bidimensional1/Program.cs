
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bidimensional1
{
    //Array de dos dimensiones
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter Bidimensional1;
            int[,] notas1 = new int[2, 2];
            //Dos bloques de 2 datos
            notas1[0, 0] = 1;
            notas1[0, 1] = 2;
            notas1[1, 0] = 3;
            notas1[1, 1] = 4;

            Bidimensional1 = new StreamWriter("Bidimensional1.txt");
            int[,] notas2 = 
            //Dos bloques de 10 datos , prefijados
            {
                { 1,2,3,4,5,6,7,8,9,10}, { 11,12,13,14,15,16,17,18,19,20}
            };
            Console.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}", notas1[0, 1]);
            Console.WriteLine("La nota2 del tercer alumno del grupo 1 es {0}", notas2[0, 2]);
            Bidimensional1.WriteLine(notas1[0, 1]);
            Bidimensional1.WriteLine(notas2[0, 2]);
            Bidimensional1.Close();
            Console.ReadKey();
        }
     

       
    }
}
