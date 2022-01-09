using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    public class NombreArchivoInvalidoException : ArgumentException
    {
        public NombreArchivoInvalidoException (String m):base(m)
        {

        }
    }
}
