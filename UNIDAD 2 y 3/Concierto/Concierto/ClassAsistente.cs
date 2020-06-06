using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
   public class ClassAsistente       
    {
        //Atributos de la clase
        public int bebes=0, niños=0, adultos=0, terceraedad=0;
        public int num1 = 0, num2 = 0, num3 = 0, num4 = 0;
        public string personas;
         //Metodos de la clase
        public void Registro()
        {
       
            switch (personas)
                {
                case "Bebes":
                    bebes = bebes + num1;
                    break;
                case "Niños":
                    niños = niños + num2;
                    break;
                case "Adultos":
                    adultos = adultos + num3;
                    break;
                case "Tercera edad":
                    terceraedad = terceraedad + num4;
                    break;
                }










        }









    }
}
