using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidimensionales_1_2
{
    class Bidi12
    {
        public void HacerArchivo()
        {
            using (Stream fs = new FileStream("Bidimensional2.txt", FileMode.Create, FileAccess.Write))
            {
                int[][] notas; //Array de dos dimensiones
                notas = new int[3][];  //Serán 3 bloques de datos
                notas[0] = new int[10]; //10 notas en un grupo
                notas[1] = new int[15]; //15 notas en otro grupo
                notas[2] = new int[12]; //12 notas en el último

                //Damos valores de ejemplo
                for (int i = 0; i < notas.Length; i++)
                {
                    for (int j = 0; j < notas[i].Length; j++)
                    {
                       notas[i][j] = i + j;
                    }
                }

                //Y mostramos esos valores
                for (int i = 0; i < notas.Length; i++)
                {
                   for (int j = 0; j < notas.Length; j++)
                   {
                      Console.WriteLine(" {0}", notas[i][j]);
                   }
                   Console.WriteLine();
                }
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    //Y mostramos esos valores
                    for (int i = 0; i < notas.Length; i++)
                    {
                        for (int j = 0; j < notas.Length; j++)
                        {
                            sw.WriteLine(" {0}", notas[i][j]);
                        }
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
            }
                
        }
    }
}
