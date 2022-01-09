using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Buscador
    {
        public List <String> elementos { get; set; }
        public String GetElemento(List<String> elementos, Int32 i)
        {
            if (elementos.Count < i)
            {
                throw new FueraDeRangoException("OJO!");
            }
            return elementos[i];
        }
    }
}
