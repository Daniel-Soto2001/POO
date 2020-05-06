using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N;
            int cantidad;
            int mayor;
            int menor;
            Console.WriteLine("Ingrese el tamaño del arreglo");
            cantidad = int.Parse(Console.ReadLine());
            N = new int[cantidad];
            
            for(int i=0; i<cantidad; i++)
            {
                Console.WriteLine("Ingrese el elemnto " + (i + 1) + " : ");
                N[i] = int.Parse(Console.ReadLine());
            }


            mayor = N[0];
            menor = N[0];
            for(int i=0; i<cantidad;i++)
            {
                if (N[i] > mayor)
                    mayor = N[i];

                else if (N[i] < menor)
                    menor = N[i];
            }

            Console.WriteLine("El mayor de los elementos es : " + mayor);
            Console.WriteLine("El menor de los elementos es : " + menor);


           Console.ReadKey();
        }
    }
}
