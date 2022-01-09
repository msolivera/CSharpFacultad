using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class ParametroNuloException:NullReferenceException
    {
        public ParametroNuloException(String m):base(m)
        {

        }
    }
}
