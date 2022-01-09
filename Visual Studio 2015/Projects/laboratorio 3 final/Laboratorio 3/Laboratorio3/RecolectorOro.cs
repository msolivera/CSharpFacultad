using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class RecolectorOro:Edificio, IRecolector
    {
        public Int32 CapacidadMaxima { get; set; } 
        public Int32 RecoleccionPorSegundo { get; set; }
        

        public RecolectorOro():base("Recolector de Oro",300,12,150)
        {
            RecoleccionPorSegundo = 1;
            CapacidadMaxima = 1000; 
        }
        /// <summary>
        /// Devuelve la capacidad maxima, que seria todo el Elixir oscuro recolectado
        /// </summary>
        /// <returns>Elixir oscuro recolectado</returns>
        public Int32 Recolectar()
        {

            return CapacidadMaxima;
        }

    }
}
