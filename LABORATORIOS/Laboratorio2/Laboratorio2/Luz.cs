using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Luz : DispositivoElectronico 
    {
        public Int32 lumens { get; set; }
        public Int32 intensidadActual { get; set; }

        public Luz (String nombre, String marca, Int32 lumens) : base(nombre, marca)
        {
            this.lumens = lumens;
            this.intensidadActual = 0;
        }
        /// <summary>
        /// Enciender la luz
        /// </summary>
        public override void Encender()
        {
            if (this.Estado == false)
            {
                this.Estado = true;
                this.intensidadActual = 100;

            }


        }
        /// <summary>
        /// Apaga la luz
        /// </summary>
        public override void Apagar()
        {
            if (this.Estado == true)
            {
                this.Estado = false;
                this.intensidadActual = 0;

            }
        }

}

      
   
}
