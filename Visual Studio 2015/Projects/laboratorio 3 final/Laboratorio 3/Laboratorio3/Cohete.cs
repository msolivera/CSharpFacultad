using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Cohete:DefensaAntiAerea
    {
        public Cohete(String nombre, Int32 vida, Int32 lvl, Int32 costeCreacion, String tipo, float dps, Int32 consumoRojo, Int32 consumoNegro) : base(nombre, vida, lvl, costeCreacion, tipo, dps, consumoRojo, consumoNegro)
        {
        }

    }
}
