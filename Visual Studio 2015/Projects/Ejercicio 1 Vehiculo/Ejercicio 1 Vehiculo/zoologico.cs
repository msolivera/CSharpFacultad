using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Zoologico

    {   private readonly string nombreZoo;
        private List<Animales> Animales;
        public Zoologico(string nombre)
        {
            this.nombreZoo = nombre;
           Animales = new List<Animales>();
         }
        public void Agregar(Animales animal)
        {
            Animales.Add(animal);
        }
        public void MismaComida(string comida)
        {
            foreach (Animales a in Animales)
            {
                if (a.comida == comida)
                {
                    Console.WriteLine(a);
                }
                
            }
        }
        public void DarDeComer ()
        {
            foreach (Animales a in Animales)
            
           
                {
                    Console.WriteLine("El "+a.raza+ " esta comiendo "+a.comida+" :)");
                }
            
        }

            
    }
}
