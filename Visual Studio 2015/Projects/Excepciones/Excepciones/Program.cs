using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            ///......
            ///
            
            try
            {
                Buscador b = new Buscador();
                String x = b.GetElemento(elementos, 10);///???
            }
            catch (FueraDeRangoException c)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
