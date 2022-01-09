using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Composicion_Delegacion
{
    class SIM
    {
        private readonly String servicioTelefonico;
        private readonly Int32 numeroTelefonico;
        public Celular celVinculado { get; set; }

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

        public SIM(String servicio, Int32 numero)
        {
            this.servicioTelefonico = servicio;
            this.numeroTelefonico = numero;
        }
        public void EnviarSMS (String mensaje, Int32 numero)
        {
            Console.WriteLine("Enviando mensaje a "+numero);
        }
        public void Llamar (Int32 numero)
        {
            Console.WriteLine("Llamando a "+numero);
        }
    }
}
