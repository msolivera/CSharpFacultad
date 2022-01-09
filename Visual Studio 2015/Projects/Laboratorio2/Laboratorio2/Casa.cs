using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Casa
    {
        public List<DispositivoElectronico> dispositivosElectronicos { get; set; }
        public List<DispositivoInteligente> dispositivosInteligentes { get; set; }
        private readonly String direccion;


        public Casa (String direccion)
        {
            this.direccion = direccion;
            dispositivosElectronicos = new List<DispositivoElectronico>();
            dispositivosInteligentes = new List<DispositivoInteligente>();
                
        }
        /// <summary>
        /// Devuelve la direccion de la casa
        /// </summary>
        /// <returns>Direccion de la casa</returns>
        public String GetDireccion()
        {
            return this.direccion;
        }
        /// <summary>
        /// Agrega un dispositivo electronico, no inteligente, a la casa
        /// </summary>
        /// <param name="dispositivo">Dispositivo agregar</param>
        public void ComprarDispositivo(DispositivoElectronico dispositivo)
        {
            dispositivosElectronicos.Add(dispositivo);
        }
        /// <summary>
        /// Agrega un dispositivo inteligente a la casa
        /// </summary>
        /// <param name="dispositivo">Dispositivo inteligente a agregar</param>
        public void ComprarDispositivoInteligente(DispositivoInteligente dispositivo)
        {
            dispositivosInteligentes.Add(dispositivo);
        }
        /// <summary>
        /// Elimina un dispositivo de la casa
        /// </summary>
        /// <param name="dispositivo">Dispositivo a eliminar</param>
        public void DesecharDispositivo(DispositivoElectronico dispositivo)
        {
            dispositivosElectronicos.Remove(dispositivo);
        }
        /// <summary>
        /// Apaga todo los dispositivos de la casa
        /// </summary>
        public void Apagon()
        {
            foreach (DispositivoElectronico dispositivo in dispositivosElectronicos)
            {
                if (dispositivo.Estado == true)
                {
                    dispositivo.Apagar();
                }
                Console.WriteLine("Se apagaron todo los dispositivos");
            }
        }

        /// <summary>
        /// Apaga un dispositivo de la casa
        /// </summary>
        /// <param name="dispo">Dispositivo a apagar</param>
        public void ApagarUnDispositivo(DispositivoElectronico dispo)
        {
            foreach (DispositivoElectronico dispositivo in dispositivosElectronicos)
            {
                if (dispo == dispositivo)
                {
                    if (dispositivo.Estado == true)
                    {
                        dispositivo.Apagar();
                    }
                
                }
            }
        }

        /// <summary>
        /// Enciende un dispositivo de la casa
        /// </summary>
        /// <param name="dispo">Dispositivo a apagar</param>
        public void PrenderUnDispositivo(DispositivoElectronico dispo)
        {
            foreach (DispositivoElectronico dispositivo in dispositivosElectronicos)
            {
                if (dispo == dispositivo)
                {
                    if (dispositivo.Estado == false)
                    {
                        dispositivo.Encender();
                    }

                }
            }
        }
        /// <summary>
        /// Apaga, de forma remota, a todos los dispositivos inteligentes
        /// </summary>
        public void ApagarRemotamente()
        {
            foreach (DispositivoInteligente  dispositivo in dispositivosInteligentes)

            {
                dispositivo.Apagar();
            }
        }
        /// <summary>
        /// Muestra la ficha de todos los dispositivos
        /// </summary>
        public void MostrarFichas()
        {
            foreach (DispositivoElectronico disp in dispositivosElectronicos)
            {
                disp.Ficha();
            }
        }
    }
}
