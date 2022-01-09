using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Cerveza
    {
        public Int32 Codigo { get; set; }
        public String Marca { get; set; }
        public Int32 Precio { get; set; }
        public String Tipo { get; set; }

        public Cerveza (Int32 codigo, String marca, Int32 precio)
        {
            Codigo = codigo;
            Marca = marca;
            Precio = precio;
        } 


    }
}
