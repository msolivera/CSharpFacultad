using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BuscaMinas;

namespace Obligatorio
{
    public class Shape:IShape
    {
        public List<IPoint> Puntos { get; set; }

        public Shape()
        {
            Puntos = new List<IPoint>();
        }
        public Color ShapeColor { get; set; }

        /// <summary>
        /// Función que agrega un punto a la lista de puntos de un shape.
        /// </summary>
        /// <param name="p">Objeto punto</param>
        public void AgregarPunto(IPoint p)
        {
            Puntos.Add(p);
        }
        /// <summary>
        /// Lista de puntos que conforman un shape
        /// </summary>
        /// <returns>Lista de puntos</returns>
        public List<IPoint> Points()
        {            
            return Puntos;
        }
        


    }
}
