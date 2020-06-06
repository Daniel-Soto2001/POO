using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSumaFCD
{
    class ClaseSumaFCD
    {
        public int Cant { get; set; }
        
        public string [,] FilCol { get; set; }
        public int [] Fila { get; set; }
        public int [] Colu { get; set; }
        public int [] Diago { get; set; }

       public void SumaFilas()
        {
            int FL=0;
            for(int f=0;f<FilCol.GetLength(0);f++)
            {
                int SumaF=0;
                int acumF=0;
                for(int c=0;c<FilCol.GetLength(0);c++)
                {
                    SumaF = Convert.ToInt32(FilCol[f, c]);
                    acumF += SumaF;
                }
                Fila[FL] = acumF;
                FL++;
            }
        }
        public void SumaColumnas()
        {
            int CL = 0;
            for (int c = 0; c < FilCol.GetLength(0); c++)
            {
                int SumaC = 0;
                int acumC = 0;
                for (int f = 0; f < FilCol.GetLength(0); f++)
                {
                    SumaC = Convert.ToInt32(FilCol[f, c]);
                    acumC += SumaC;
                }
                Colu[CL] = acumC;
                CL++;
            }
        }
        public string SumaDiagonal()
        {
            string DL;
            int AcumD = 0;
            for(int f=0;f<FilCol.GetLength(0);f++)
            {
                int SumaD = 0;
                for(int c=0;c<FilCol.GetLength(0);c++)
                {
                    if(f==c)
                    {
                        SumaD = Convert.ToInt32(FilCol[f, c]);
                        AcumD += SumaD;
                    }
                }
            }
            DL = Convert.ToString(AcumD);
            return DL;    
        }
        public string ImprimirFilas()
        {
            string FL2;
            int AcumFL = 0;
            for(int f=0;f<FilCol.GetLength(0);f++)
            {
                int SumaFL;
                for(int c=0;c<FilCol.GetLength(0);c++)
                {
                    SumaFL = Convert.ToInt32(FilCol[f, c]);
                    AcumFL += SumaFL;
                }
            }
            FL2 = Convert.ToString(AcumFL);
            return FL2;
        }
        public string ImprimirColumnas()
        {
            string CL2;
            int AcumCL = 0;
            for (int c = 0; c < FilCol.GetLength(0); c++)
            {
                int SumaCL;
                for (int f = 0; f < FilCol.GetLength(0); f++)
                {
                    SumaCL = Convert.ToInt32(FilCol[f, c]);
                    AcumCL += SumaCL;
                }
            }
            CL2 = Convert.ToString(AcumCL);
            return CL2;
        }


    }
}
