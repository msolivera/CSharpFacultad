using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cocinero
    {
        public readonly String nombre;


        public Cocinero (String nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Funcion que permite al cocinero Cocinar
        /// </summary>
        public void Cocinar ()
        {
            Console.WriteLine("Ha finalizado la preparacion de la comida");
        }
    }
}
