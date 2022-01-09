using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Jugador

    {
        public static List<Jugador> lista = new List<Jugador>();
        private string nombre;
        private string apellido;
        public int edad;
        public string Posicion { get; set; }

        private string Nombre
        {
            get { return this.nombre; }
        }
        private string Apellido
        {
            get { return this.apellido; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public Jugador(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = 0;
            this.Posicion = "";
        }


        string resultado = "";
        public static void Añadir(Jugador jugador)
        {
            lista.Add(jugador);
        }


        public static int Promedio(List<Jugador> lista)
        {
            int total = 0;
            int contador = 0;
            int resultado = 0;
            foreach (Jugador elemento in lista)
            {
                total = elemento.Edad + total;
                contador++;

            }
            resultado = total / contador;
            return resultado;

        }

    }


}


