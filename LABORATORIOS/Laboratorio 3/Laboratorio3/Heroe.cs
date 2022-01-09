﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class Heroe:Tropa
    {
        public String Habilidad { get; set; }
        public Int32 Costo { get; set; }

        public Heroe (String nombre, Int32 vida, Int32 lvl, float vel, float dps, Int32 espacio,Int32 costo, String habilidad):base(nombre, vida, lvl, vel, dps, espacio, costo)
        {
            Habilidad = habilidad;
            Costo = costo;
        }
    }
}
