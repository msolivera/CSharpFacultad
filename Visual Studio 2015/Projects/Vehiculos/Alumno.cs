using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Vehiculo
    {
        private int kilometraje;
        private readonly string marca; 
        public string Matricula { get; set; }
        public Vehiculo(string marca)
        {
            this.marca = marca;
            this.Matricula = "";
            this.kilometraje = 0;
        }
        public string Marca
        {
            get { return this.marca; }
        }
        public int Kilometraje
        {
            get { return this.kilometraje; }
        }
        /// <summary>
        /// Recorre los kilometros pasados por parametro y aumenta el kilometraje
        /// </summary>
        /// <param name="kms">Kilometros a recorrer</param>
        public void Recorrer(int kms)
        {
            if (this.Matricula != "")
            {
                this.kilometraje += kms;
            }   
        }
    }
}
