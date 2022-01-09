using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Producto
    {
        public readonly Int32 codigo;
        public readonly String nombre;
        public Int32 precio { get; set; }

        public Producto (String nombre, Int32 precio)
        {
            this.codigo = Restaurant.DarCodigo();
            this.nombre = nombre;
            this.precio = precio;
            Restaurant.AñadirStock(this);
        }
        /// <summary>
        /// Muesta la ficha final del Objeto Producto creado.
        /// </summary>
        public void Ficha()
        {
            Console.WriteLine("Codigo:"+this.codigo+" "+this.nombre+" Precio: "+this.precio+"$\n");
        }
    }
}
