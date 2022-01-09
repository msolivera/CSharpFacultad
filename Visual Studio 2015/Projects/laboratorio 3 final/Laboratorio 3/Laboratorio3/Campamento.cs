using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Campamento : Edificio
    {
        public Int32 CapacidadMaxima { get; set; }
        
        public Campamento (String nombre, Int32 vida, Int32 lvl, Int32 coste):base(nombre,vida,lvl, coste)
        {
            CapacidadMaxima = 50;

        }

        
    }
}
