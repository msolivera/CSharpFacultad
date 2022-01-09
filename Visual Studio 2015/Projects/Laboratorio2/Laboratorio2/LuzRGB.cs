using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class LuzRGB:LuzInteligente
    {
        public String Color { get; set; }
        public LuzRGB(TarjetaRed tarjeta, String nombre, String marca, Int32 lumens) : base(tarjeta, nombre, marca,lumens)
        {
            this.Color = "Amarillo";
        }

        /// <summary>
        /// Cambia el color de las luces
        /// </summary>
        /// <param name="colorNuevo">Color deseado</param>
        public void CambiarColor(String colorNuevo)
        {
            this.Color = colorNuevo;
        }
    }
}
