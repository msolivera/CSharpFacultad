using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Bitter: ICerveza
    {
        public double LeerDensidad()
        {
            return 0;
        }
        public void AgregarLevadura(double cantidad)
        {

        }
        public void TerminacionDeFermentacion()
        {
            if (this.LeerDensidad() > 1000)
            {
                this.AgregarLevadura(8);
            }
        }
    }
}
