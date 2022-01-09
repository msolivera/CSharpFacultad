using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Animales
    {
        public readonly string raza;
        public int Peso { get; set; }
        public string comida { get; set; }

        public Animales(String raza, string comida,int peso)
        {
            this.raza = raza;
            this.Peso = peso;
            this.comida = comida;
             
        }

        

    }
}
