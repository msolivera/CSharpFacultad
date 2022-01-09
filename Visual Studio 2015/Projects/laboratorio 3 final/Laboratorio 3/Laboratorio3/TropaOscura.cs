using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class TropaOscura:Tropa
    {
        public Int32 CosteElixirNegro { get; set; }

        public TropaOscura (String nombre, Int32 vida, Int32 lvl, float vel, float dps, Int32 espacio, Int32 costeNegro):base(nombre, vida, lvl, dps,vel, espacio, costeNegro)
        {
            CosteElixirNegro = costeNegro;
        }
    }
}
