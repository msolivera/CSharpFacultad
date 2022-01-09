using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class CastilloDeClan:Edificio
    {
        public Int32 CantidadOro { get; set; }
        public Int32 CapacidadTropas { get; set; }
        //public List<Tropa> { get; set; }
        public Int32 CantidadElixirRojo { get; set; }
        public Int32 CantidadElixirNegro { get; set; }

        public CastilloDeClan(String nombre, Int32 vida, Int32 lvl) : base(nombre, vida, lvl)
        {
            //cantidades donde se ponen?
        }
    }
}
