using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class LuzDimirizable : Luz
    {
        public LuzDimirizable(String nombre, String marca, Int32 lumens) : base(nombre, marca, lumens)
        {

        }
        /// <summary>
        /// Ajusta la intensidad de la luz
        /// </summary>
        /// <param name="porcentajeIntensidad">Intensidad deseada</param>
        public void AjustarIntensidad(Int32 porcentajeIntensidad)
        {
            if (!(porcentajeIntensidad == 0))
            {
                if (!(porcentajeIntensidad<0 || porcentajeIntensidad > 100))
                {
                    if (this.Estado == true)
                    {
                        intensidadActual = porcentajeIntensidad;
                    }
                    else
                    {
                        this.Estado = true;
                        intensidadActual = porcentajeIntensidad;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un valor entre 0 y 100 \n");
                }

            }
            else
            {
                intensidadActual = 0;
                this.Estado = false;
            }

        

        }
    }
}
