using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
     public class IPA:Cerveza
    {
      

        public IPA(Int32 codigo, String marca, Int32 precio):base(codigo,marca,precio)
        {
            this.Tipo = "IPA";

        }


    }
}
