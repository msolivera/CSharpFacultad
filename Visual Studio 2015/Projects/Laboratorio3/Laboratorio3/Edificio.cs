using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    abstract class Edificio
    {
        public String Nombre { get; set; }
        public Int32 Vida { get; set; }
        public Int32 Nivel { get; set; }

        public Edificio (String n, int v, int lvl)
        {
            Nombre = n;
            Vida = v;
            Nivel = lvl;
        }

    }
}
