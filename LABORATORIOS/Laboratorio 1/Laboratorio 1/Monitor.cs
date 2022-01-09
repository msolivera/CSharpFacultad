using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class Monitor
    {
        public readonly Int32 id;
        public readonly String marca;
        public readonly String resolucion;

        public Monitor(String marca, String resolucion)
        {
            this.id = Local.DarId();
            this.marca = marca;
            this.resolucion = resolucion;
            Local.AñadirComponente(this);
        }
        /// <summary>
        /// Impresión de valores asociados al objeto.
        /// <returns>Devuelve una cadena estructurada con los valores pertenecientes al objeto</returns>
        public String Imprimir()
        {
            return "Marca: " + this.marca + " Resolucion: " + this.resolucion;
        }
    }
}
