using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class AlmacenOro:Almacen

    {
     
        public AlmacenOro ():base("Almacen de Oro", 1600, 12, 300, 1000, 0)
        {

          
        }
        public override void  Almacenar(Int32 recurso)
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
