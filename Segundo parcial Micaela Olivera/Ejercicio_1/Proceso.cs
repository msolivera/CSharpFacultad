using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_1
{
    public class Proceso
    {
        public List <ICerveza> Cervezas { get; set; }
        public void VerificarTerminacionFermentacion(List <ICerveza> cervezas)
        {

            foreach (ICerveza c in cervezas)
            {
                c.TerminacionDeFermentacion();
            }
        }
    }
}
