using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            

            Console.WriteLine("Introduce un numero ");
            a =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un numero ");
            b =Convert.ToInt32 (Console.ReadLine());
            c = a + b;
            Console.WriteLine("La suma es: " + c);
           
            Console.ReadKey();






        }
    }
}
