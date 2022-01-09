using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Horno
    {
        public readonly String marcaHorno;
        public Int32 temperaturaHorno { get; set; }

        public Horno (String marcaHorno)
        {
            this.marcaHorno = marcaHorno;
            this.temperaturaHorno = 0;
        }
    }
}
