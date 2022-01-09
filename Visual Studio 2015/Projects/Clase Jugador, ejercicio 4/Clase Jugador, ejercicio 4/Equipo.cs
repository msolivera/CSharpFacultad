using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Jugador__ejercicio_4
{
    class Equipo
    {
        private readonly String nombre_equipo;
        public static List<Jugador> lista;

        public Equipo (String nombre_equipo)
        {
            this.nombre_equipo = nombre_equipo;
            lista = new List<Jugador>();


        }
        public static void Añadir(Jugador jugador)
        {
            lista.Add(jugador);
        }
        public static String Edad_Promedio()
        {
            int suma = 0;
            int promedio = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                suma = suma + lista[i].edad;
            }
            int CantJugadores = lista.Count + 1;
            promedio = promedio + suma / CantJugadores;
            String prom = promedio.ToString();
            return prom;
        }
        public static void Eliminar(Jugador jugador)
        {
            lista.Remove(jugador);
        }
        public static void Jugadorporposicion(String pos)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].posicion.ToString() == pos)
                {
                    Console.WriteLine(lista[i].GetNombre() + " " +  lista[i].GetApellido() + " "+ lista[i].edad.ToString());

                }
            }

        }
        public static void Jugadores()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].GetNombre() + " " + lista[i].GetApellido() + " " + lista[i].edad.ToString() + lista[i].posicion);
            }
        }
        




    }
}
