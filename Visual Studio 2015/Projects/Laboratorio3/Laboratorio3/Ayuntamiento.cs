using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Ayuntamiento:Edificio
    {
        public Int32 CantidadOro { get; set; }
        public Int32 CantidadElixirRojo { get; set; }

        public Ayuntamiento (string nombre, Int32 vida, Int32 lvl):base(nombre,vida,lvl)
        {
            CantidadOro = 0;
            CantidadElixirRojo = 0;
        }
    }
}
