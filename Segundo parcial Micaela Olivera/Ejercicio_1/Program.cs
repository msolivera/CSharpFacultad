using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modifique el codigo anterior del proyecto para que la clase Proceso cumpla 
            // con OCP. Brinde un ejemplo agregando un nuevo tipo de cerveza Bitter.
            Porter p = new Porter();
            Bitter b = new Bitter();
            IPA i = new IPA();
            Proceso proceso = new Proceso();
            List<ICerveza> ListaCervezas = new List<ICerveza>();
            ListaCervezas.Add(p);
            ListaCervezas.Add(b);
            ListaCervezas.Add(i);
            proceso.VerificarTerminacionFermentacion(ListaCervezas);
        }
    }
}
