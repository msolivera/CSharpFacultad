using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Heladera
    {
        public readonly String marcaHeladera;
        public bool puertaDeLaHeladeraAbierta { get; set; }


        public Heladera (String marcaHeladera)
        {
            this.marcaHeladera = marcaHeladera;
            this.puertaDeLaHeladeraAbierta = false;
        }
    }
}
