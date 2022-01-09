using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class CastilloDeClan:Edificio
    {
        public Int32 CantidadOroActual { get; set; }
        public Int32 CantidadElixirActual { get; set; }
        public Int32 CantidadElixirNegroActual { get; set; }
        public Int32 CantidadActualTropas { get; set; }
        public Int32 CapacidadMaximaTropas { get; set; }   
        public Int32 CapacidadOro { get; set; }

        public Int32 CapacidadElixirRojo { get; set; }
        public Int32 CapacidadElixirNegro { get; set; }

        public CastilloDeClan(String nombre, Int32 vida, Int32 lvl, Int32 coste) : base(nombre, vida, lvl, coste)
        {
            CantidadOroActual = 0;
            CantidadElixirActual = 0;
            CantidadElixirNegroActual = 0;
            CapacidadMaximaTropas = 25;
            CantidadActualTropas = 0;
            CapacidadOro = 5000;
            CapacidadElixirRojo = 7500;
            CapacidadElixirNegro = 3000;
        }
    }
}
