using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class DispositivoInteligente:DispositivoElectronico
    {
        public TarjetaRed tarjetaRed;


        public DispositivoInteligente(TarjetaRed tarjeta, String nombre, String marca) : base(nombre, marca)
        {
            this.tarjetaRed = tarjeta;
        }
        
    }
}
