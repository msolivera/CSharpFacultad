using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    public class NoExisteArchivoException : Exception
    {
        public NoExisteArchivoException (String m):base(m)
        {

        }
    }
}
