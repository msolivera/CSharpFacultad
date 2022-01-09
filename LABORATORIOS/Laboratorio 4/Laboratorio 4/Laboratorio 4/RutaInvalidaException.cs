using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    public class RutaInvalidaException:Exception
    {
        public RutaInvalidaException (String m):base(m)
        {

        }
    }
}
