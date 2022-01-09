using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class Tropa
    {
        public String Nombre { get; set; }
        public Int32 Vida { get; set; }
        public Int32 Nivel { get; set; }
        public float VelocidadEnMapa { get; set; }
        public float DPS { get; set; } //Daño por segundo
        public Int32 EspacioEnCampamento { get; set; }
        //public Int32 CostoElixir { get; set; }

        public Tropa(String n, Int32 vida, Int32 lvl, float vel, float dps, Int32 espacio, Int32 costo)
        {
            Nombre = n;
            Vida = vida;
            Nivel = lvl;
            VelocidadEnMapa = vel;
            DPS = dps;
            EspacioEnCampamento = espacio;
            //CostoElixir = costo;
        }
    }
}
