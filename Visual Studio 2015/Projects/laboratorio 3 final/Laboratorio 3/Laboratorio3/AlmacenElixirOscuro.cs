using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class AlmacenElixirOscuro:Almacen
    {
        

        public AlmacenElixirOscuro():base("Almacen de Elixir Oscuro", 2600, 6, 600, 7500, 0)
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
