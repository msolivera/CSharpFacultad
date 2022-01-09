using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class ParametroNoNumericoException: ArgumentException
    {
        public ParametroNoNumericoException(String m):base(m)
        {

        }
    }
}
