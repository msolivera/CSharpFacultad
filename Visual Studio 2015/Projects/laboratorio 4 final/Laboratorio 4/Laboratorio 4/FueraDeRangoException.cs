using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    public class FueraDeRangoException : Exception
    {
        public FueraDeRangoException(string m):base(m) { }


    }
}
