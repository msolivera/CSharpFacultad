using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BuscaMinas;


namespace BataBatallaNaval
{
    public class Shape : IShape
    {
        public List<IPoint> Puntos { get; set; }

        public Shape()
        {
            Puntos = new List<IPoint>();
        }
        public Color ShapeColor { get; set; }

        /// <summary>
        /// Agrega un punto a un shape
        /// </summary>
        /// <param name="p">Punto</param>
        public void AgregarPunto(IPoint p)
        {
            Puntos.Add(p);
        }
        /// <summary>
        /// Devuelve la lista de puntos de un shape
        /// </summary>
        /// <returns>Puntos</returns>

        public List<IPoint> Points()
        {
            return Puntos;
        }



    }
}
