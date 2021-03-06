using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class Mouse
    {
        public readonly Int32 id;
        public readonly String marca;
        public readonly Int32 cantidadBotones;

        public Mouse (String marca, Int32 cantidadBotones)
        {
            this.id = Local.DarId();
            this.marca = marca;
            this.cantidadBotones = cantidadBotones;
            Local.AñadirComponente(this);

        }
        /// <summary>
        /// Impresión de valores asociados al objeto.
        /// <returns>Devuelve una cadena estructurada con los valores pertenecientes al objeto</returns>
        public String Imprimir()

        {
            return "Marca: " + this.marca + " Cantidad de Botones: " + this.cantidadBotones.ToString();
        }
    }
}
