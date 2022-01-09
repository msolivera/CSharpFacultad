using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class DispositivoElectronico
    {
        private readonly String nombre;
        private readonly String marca;
        public bool Estado { get; set; }

        public DispositivoElectronico (String nombre, String marca)
        {
            this.marca = marca;
            this.nombre = nombre;
            this.Estado = false;
        }
        /// <summary>
        /// Devuelve el nombre del dispositivo
        /// </summary>
        /// <returns>Nombre</returns>
        public String GetNombre()
        {
            return nombre;
        }
        /// <summary>
        /// Devuelve la marca del dispositivo
        /// </summary>
        /// <returns>Marca del dispositivo </returns>
        public String GetMarca()
        {
            return marca;
        }
        /// <summary>
        /// Imprime los datos de un dispositivo
        /// </summary>
        public void Ficha ()
        {
            if (this.Estado == true)
            {
                Console.WriteLine("Nombre: " + nombre + " Marca: " + marca + " Estado encendido");
            }

            else
            {
                Console.WriteLine("Nombre: " + nombre + " Marca: " + marca + " Estado apagado");
            }
        }
        /// <summary>
        /// Enciende el dispositivo
        /// </summary>
        public virtual void Encender()
        {
            this.Estado = true;
        }
        /// <summary>
        /// Apaga el dispositivo
        /// </summary>
        public virtual void Apagar()
        {
            this.Estado = false;
        }

    }
}
