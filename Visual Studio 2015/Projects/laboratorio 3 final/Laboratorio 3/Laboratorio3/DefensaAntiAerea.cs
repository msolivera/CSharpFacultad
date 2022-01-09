using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class DefensaAntiAerea:Defensa
    {
        public DefensaAntiAerea(String nombre, Int32 vida, Int32 lvl, Int32 costeCreacion, String tipo, float dps, Int32 consumorojo, Int32 consumonegro) : base(nombre, vida, lvl, costeCreacion, tipo, dps, consumorojo, consumonegro)
        {

        }
    }
}
