using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class IPA : ICerveza
    {
        public double LeerDensidad()
        {
            /* Se lee la densidad del mosto */
            return 0; // retorna 0 solo con el fin de compilar el proyecto.-
        }
        public void AgregarLevadura(double cantidad)
        {
            // Agrega levadura al fermentador
        }
        public void TerminacionDeFermentacion()
        {
            if (this.LeerDensidad() > 1060)
            {
                this.AgregarLevadura(5);
            }
        }
    }
}
