using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class AlmacenElixirRojo:Almacen
    {
       

        public AlmacenElixirRojo ():base("Almacen de Elixir Rojo", 1400, 12, 300, 4500, 0)
        {
          
        }
        public override void Almacenar(Int32 recurso)
        {
          
            if (CantidadActual + recurso <= CapacidadMaxima)
            {
                CantidadActual += recurso;
            }
            else
            {
                CantidadActual = CapacidadMaxima;
            }
        }

    }
}
