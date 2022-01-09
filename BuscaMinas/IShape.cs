using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    /// <summary>
    /// Representación de una figura. Cada figura es representada por un conjunto de puntos en un tablero virtual de 100x100
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Color de la figura
        /// </summary>
        Color ShapeColor { get; }
        /// <summary>
        /// Listado de puntos que delimitan la figura
        /// </summary>
        /// <returns></returns>
        List<IPoint> Points();
    }
}
