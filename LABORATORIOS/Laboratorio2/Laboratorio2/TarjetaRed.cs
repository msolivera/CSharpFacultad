using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class TarjetaRed
    {
        public String Ip { get; set; }
        public readonly String mac;

        public TarjetaRed (String ip, String mac)
        {
            this.Ip = ip;
            this.mac = mac;
        }
        /// <summary>
        /// Devuelve la direccion mac
        /// </summary>
        /// <returns>Direccion mac</returns>
        public String GetMac()
        {
            return mac;
        }
    }
}
