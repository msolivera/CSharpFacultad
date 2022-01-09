using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Blonde:Cerveza
    {
      

        public Blonde(Int32 codigo, String marca, Int32 precio):base(codigo,marca,precio)
        {
            this.Tipo = "Blonde";

        }

    }
}
