using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Composicion_Delegacion
{
    class Display
    {
        public Display()
        {}

        internal Celular Celular
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void  MostrarMensaje (String mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
