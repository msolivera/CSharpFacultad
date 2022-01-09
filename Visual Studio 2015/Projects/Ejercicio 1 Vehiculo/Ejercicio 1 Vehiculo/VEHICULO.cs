using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Vehiculo
    {
        public string matricula;
        private readonly string marca;
        private int kilometraje;

        public Vehiculo (String m)
        {
            this.marca = m ;
            this.matricula = "No tiene matricula";
            this.kilometraje = 0;
         
        }
        public string Matricula
        {
            get { return this.matricula; }
             set { this.matricula = value; }
        }
        private string Marca
        {
            get { return this.marca; }
            
        }
        public int Kilometraje
        {
            get { return this.kilometraje; }
             set { this.kilometraje = value; }
        }
        /// <summary>
        /// Cuenta los km totales a medida que se le asignan a un auto
        /// </summary>
        /// <param name="vehiculo"> es la marca del vehiculo </param>
        /// <param name="kilometros"> son los susesivos km del auto</param>
        public void CuentaKm( Vehiculo vehiculo, int kilometros)
        {
           if (vehiculo.Matricula == "No tiene matricula")
            {
                Console.WriteLine("No puede salir a la calle sin matricula");
            }
           else
            {
                vehiculo.Kilometraje = vehiculo.Kilometraje + kilometros;
            }
           Console.WriteLine("El auto "+ Marca+" De matricula "+Matricula+" Recorrio: "+vehiculo.Kilometraje+" kilometros");
        }
      
    }
}
