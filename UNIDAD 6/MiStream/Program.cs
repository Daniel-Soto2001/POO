using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiStream
{
    class Program
    {
        

        static void Main(string[] args)
        {
            using (Stream ms = new MemoryStream())
            {
                using (Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read))
                {
                    fs.CopyTo(ms);
                }
                ms.Seek(0, SeekOrigin.Begin);

                using (StreamReader sr = new StreamReader(ms))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }

            }
            using (Stream fs = new FileStream("./archivo.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                   
                    sw.WriteLine("Hola mi nombre es carlos daniel elias soto");
                    sw.WriteLine("Este es mi trabajo");
                }
            }
            Console.ReadKey();
        }
    }
}
