using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class Almacen:Edificio
    {
        public Int32 CapacidadMaxima { get; set; }
        public Int32 CantidadActual { get; set; }

        public Almacen (String nombre, Int32 vida, Int32 nivel, Int32 coste, Int32 capacidadMax, Int32 cantidadAct ): base (nombre, vida, nivel, coste)
        {
            CapacidadMaxima = capacidadMax;
            CantidadActual = cantidadAct;
        }

        public abstract void Almacenar(Int32 recurso);
      
    }
}
