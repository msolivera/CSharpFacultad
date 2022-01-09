using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class DispositivoElectricoNoInteigenteConTemp:DispositivoElectronico
    {
        private readonly Int32 temperaturaMinima;
        public Int32 temperaturaActual { get; set; }

        public DispositivoElectricoNoInteigenteConTemp (String nombre, String marca, Int32 temperaturaMinima) : base(nombre, marca)
        {
            this.temperaturaMinima = temperaturaMinima;
            this.temperaturaActual = 0;
        }
        /// <summary>
        /// Enciende el dispositvo
        /// </summary>
        public override void Encender()
        {
            base.Encender();
            temperaturaActual = temperaturaMinima;

        }
        /// <summary>
        /// Apaga el dispositivo     
        /// </summary>
        public override void Apagar()
        {
            base.Apagar();
            temperaturaActual = 0;
        }
        /// <summary>
        /// Devuelve la temperatura minima  
        /// </summary>
        /// <returns>temperatura minima</returns>
        public Int32 GetTemperaturaMinima()
        {
            return temperaturaMinima;
        }
        /// <summary>
        /// Ajusta la temperatura del dispositivo
        /// </summary>
        /// <param name="temperatura">Temperatura deseada</param>
        public void RegularTemperatura(Int32 temperatura)
        {
            if (this.Estado == true &&temperatura >0 )
            {
                temperaturaActual = temperatura;
            }
            else
            {
                Console.WriteLine("La temperatura no puede ser cero o menor");
            }
        }


    }

    
}
