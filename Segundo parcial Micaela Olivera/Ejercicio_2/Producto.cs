using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Producto
    {
        private static Producto instancia = null;
        public List<Cerveza> Inventario { get; set; }
        public List<Cerveza> Vendidas { get; set; }
        public Producto()
        {
            Inventario = new List<Cerveza>();
            Vendidas = new List<Cerveza>();
        }
        public static Producto GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Producto();
            }
            return instancia;
        }
    }
}
