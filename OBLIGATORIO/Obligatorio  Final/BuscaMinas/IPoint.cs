using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    /// <summary>
    /// Representacion cartesiana de un punto
    /// </summary>
    public interface IPoint
    {
        /// <summary>
        /// Coordenada x del punto
        /// </summary>
        int X { get; }
        /// <summary>
        /// Coordenada y del punto
        /// </summary>
        int Y { get; }
    }
}
