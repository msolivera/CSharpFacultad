using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class Defensa:Edificio
    {
        public String Tipo { get; set; }
        public float DPS { get; set; } //Daño por segundo
        public Int32 consumoElixirRojo { get; set; }
        public Int32 consumoElixirNegro { get; set; }
        public Defensa (String nombre, Int32 vida, Int32 lvl, Int32 costeCreacion, String tipo, float dps, Int32 consumorojo, Int32 consumonegro ):base (nombre, vida, lvl, costeCreacion)
        {
            Tipo = tipo;
            DPS = dps;
            consumoElixirRojo = consumorojo;
            consumoElixirNegro = consumonegro;
        }

    }
}
