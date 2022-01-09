using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Ayuntamiento:Edificio
    {
        public Int32 CapacidadMaximaOro { get; set; }
        public Int32 CapacidadMaximaElixirRojo { get; set; }
       
        public Int32 MaximoDeTropas { get; set; }
        public Int32 CantidadTropaActual { get; set; }
        public Int32 CantidadOroActual { get; set; }
        
        public Int32 CantidadElixirRojoActual { get; set; }

        public Ayuntamiento (string nombre, Int32 vida, Int32 lvl, Int32 coste):base(nombre,vida,lvl, coste)
        {
            CantidadOroActual = 3000;
            CantidadElixirRojoActual = 5000;
            MaximoDeTropas = 20;
            CantidadTropaActual = 0;
            CapacidadMaximaOro = 5000;
            CapacidadMaximaElixirRojo = 7500;
        }
    }
}
