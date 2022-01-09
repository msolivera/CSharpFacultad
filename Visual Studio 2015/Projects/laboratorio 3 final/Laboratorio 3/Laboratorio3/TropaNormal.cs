using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class TropaNormal:Tropa
    {
        Int32 costeElixirRojo { get; set; } 

        public TropaNormal (String nombre, Int32 vida, Int32 lvl, float vel, float dps, Int32 espacio, Int32 costeRojo):base(nombre, vida, lvl, vel, dps, espacio, costeRojo)
        {
            costeElixirRojo = costeRojo;
        }
    }
}
