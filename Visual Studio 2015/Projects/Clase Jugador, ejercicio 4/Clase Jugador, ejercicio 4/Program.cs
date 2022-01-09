using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Jugador__ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("luis", "suarez");
            j1.edad = 30;
            j1.posicion = "delantero";
            Jugador j2 = new Jugador("edison", "cavani");
            j2.edad = 25;
            j2.posicion = "medio campo";
            Equipo e1 = new Equipo("seleccion");
            Equipo.Edad_Promedio();
            
            
        }
    }
}
