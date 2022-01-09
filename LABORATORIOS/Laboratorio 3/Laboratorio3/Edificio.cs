using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class Edificio
    {
        public String Nombre { get; set; }
        public Int32 Vida { get; set; }
        public Int32 Nivel { get; set; }
        public Int32 costoCreacion { get; set; }

        public Edificio (String n, int v, int lvl, int coste)
        {
            Nombre = n;
            Vida = v;
            Nivel = lvl;
            costoCreacion = coste;
        }

    }
}
