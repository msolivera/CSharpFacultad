using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class RecolectorElixirRojo:Edificio, IRecolector
    {
        public Int32 CapacidadMaxima { get; set; }
        public Int32 RecoleccionPorSegundo { get; set; }


        public RecolectorElixirRojo():base("Recolector de Elixir Rojo",300,12,150)
        {
            RecoleccionPorSegundo = 1;
            CapacidadMaxima = 1000;
        }
        /// <summary>
        /// Devuelve la capacidad maxima, que seria todo el elixir rojo recolectado
        /// </summary>
        /// <returns>Elixir rojo recolectado</returns>
        public Int32 Recolectar()
        {
            return CapacidadMaxima;
        }
    }
}
