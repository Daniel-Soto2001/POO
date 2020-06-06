using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);

            //Obtenemos el numero de bytes
            long quantity = fs.Length;
            Console.WriteLine($"El archivo tiene una longitud de {quantity} bytes");

            StreamReader sr = new StreamReader(fs);



            string todo = sr.ReadToEnd();
            Console.WriteLine(todo);
            // Muy importante cerrar el sream
            fs.Close();




            Console.ReadKey();
        }



    }
}
