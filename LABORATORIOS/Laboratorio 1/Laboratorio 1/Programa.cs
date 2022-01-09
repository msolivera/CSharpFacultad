using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class Programa
    {
        public readonly Int32 id;
        public readonly String nombre;
        public readonly String tipoPrograma;
        public Int32 peso;
        

        public Programa (String nombre, String tipoPrograma, Int32 peso)
        {
            this.id = Local.DarId();
            this.nombre = nombre;
            this.tipoPrograma = tipoPrograma;
            this.peso = peso;
            Local.AñadirComponente(this);
        }
        /// <summary>
        /// Impresión de valores asociados al objeto.
        /// <returns>Devuelve una cadena estructurada con los valores pertenecientes al objeto</returns>
        public String Imprimir()
        {
            return ("Nombre: " + this.nombre + " Tipo: " + this.tipoPrograma);
        }

    }
}
