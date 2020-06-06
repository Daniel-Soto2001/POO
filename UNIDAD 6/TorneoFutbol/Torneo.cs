using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoFutbol
{
    class Torneo
    {
        public string NombreTorneo { get; set; }
        public int NumeroEquipos { get; set; }
        public int NumeroPartidos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int PuntosGanados { get; set; }
        public int PuntosEmpate { get; set; }
        public int PuntosPerdidos { get; set; }
        public string [,] PuntajesPartido { get; set; }
        public int[] SumaPuntos { set; get; }

        public int Formula()
        {
            NumeroPartidos = NumeroEquipos - 1;
            return NumeroPartidos;
        }

        public void SumarPuntos()
        {
            int x=0;
            for (int i = 0; i< PuntajesPartido.GetLength(0); i++)
            {
                int suma = 0;
                int acumulador=0;
                      
                    for (int j = 1; j < PuntajesPartido.GetLength(1); j++)
                    {
                    suma = Convert.ToInt32(PuntajesPartido[i, j]);
                    acumulador += suma;
                    }
                SumaPuntos[x] = acumulador;
                x++;
            }
        }

        public string CalcularGanador(string EquipoGanador, int Mayor)
        {
            int PuntosMayor = 0;
            int p = 0;
            for (int i = 0; i < SumaPuntos.Length; i++)
            {
                if (SumaPuntos[i] > Mayor)
                {
                    Mayor = SumaPuntos[i];
                    PuntosMayor = p;
                }
                p++;
            }
            EquipoGanador = "El equipo ganador es: " + PuntajesPartido[PuntosMayor, 0] + " Con " + Mayor + " Puntos";
            return EquipoGanador;
        }


    }
}
