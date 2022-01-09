using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Automotora
    {
        List<Auto> lista;
        private readonly string nombre;
        
        public Automotora (string nombre)
        {
            this.nombre = nombre;
            lista = new List<Auto>();

        }

        public void Añadir (Auto a)
        {
            lista.Add(a);
        }
        public void Eliminar (Auto a)
        {
            lista.Remove(a);
        }
        public void Fichas()
        {
            foreach (Auto a in lista)
            {
                a.Ficha();
            }
        }
            
    }
}
