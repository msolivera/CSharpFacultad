using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Campamento : Edificio
    {
        public Int32 CapacidadMaxima { get; set; }
        //public List<Tropa> {get;set;}

        public Campamento (String nombre, Int32 vida, Int32 lvl):base(nombre,vida,lvl)
        {
            CapacidadMaxima = 20;

        }

        
    }
}
