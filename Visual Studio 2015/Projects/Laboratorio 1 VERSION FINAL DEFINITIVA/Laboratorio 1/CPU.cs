using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class CPU
    {
        public readonly Int32 id;
        public readonly String marca;
        public readonly String modelo;
        
        public CPU (String marca, String modelo)
        {
            this.id = Local.DarId();
            this.marca = marca;
            this.modelo = modelo;
            Local.AñadirComponente(this);

        }

        public Int32 GetId()
        {
            return id;
        }
        /// <summary>
        /// Impresión de valores asociados al objeto.
        /// <returns>Devuelve una cadena estructurada con los valores pertenecientes al objeto</returns>
        public String Imprimir()
        {
            return "Marca: " + this.marca + " Modelo: " + this.modelo;
        }

    }
}
