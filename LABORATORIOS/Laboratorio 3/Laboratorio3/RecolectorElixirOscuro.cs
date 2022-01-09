using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class RecolectorElixirOscuro:Edificio, IRecolector
    {
        public Int32 CapacidadMaxima { get; set; }
        public Int32 RecoleccionPorSegundo { get; set; }


        public RecolectorElixirOscuro():base("Recolector de Elixir Oscuro",300,12,1500)
        {
            RecoleccionPorSegundo = 1;
            CapacidadMaxima = 1000;
        }
        /// <summary>
        /// Devuelve la capacidad maxima, que seria todo el oro recolectado
        /// </summary>
        /// <returns>Oro recolectado</returns>
        public Int32 Recolectar()
        {
        
            return CapacidadMaxima;
        }

    }
}
