using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidimensional2
{
    //Arrays de Arrays
    class Program
    {
        static void Main(string[] args)
        {
            int[][] notas;  //Array de dos dimensiones
            notas = new int[3][]; //Seran 3 bloques de datos
            notas[0] = new int[10]; //10 notas en un grupo
            notas[1] = new int[15]; //15 notas en otro grupo
            notas[2] = new int[12]; //12 notas en el ultimo

            //Damos valores de ejemplo 
            for(int i=0; i < notas.Length;i++)
            {
                for(int j=0; j < notas[i].Length; j++)
                {
                    notas[i][j] = i + j;
                }
            }
            //Mostramos esos valores
            for(int i=0; i<notas.Length; i++)
            {
                for(int j=0; j<notas[i].Length; j++)
                {
                    Console.WriteLine("{0}", notas[i][j]);
                }

                Console.ReadKey();
            }




        }
    }
}
