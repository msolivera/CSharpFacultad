using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    /// <summary>
    /// Interfaz que representa un tablero de juego
    /// </summary>
    public interface IBoard
    {
        /// <summary>
        /// Ancho del tablero. Representa la cantidad de casilleros de ancho
        /// </summary>
        /// <returns>Cantidad de casilleros de ancho</returns>
        int Width();
        /// <summary>
        /// Altura del tablero. Representa la cantidad de casilleros de alto
        /// </summary>
        /// <returns>Cantidad de casilleros de alto</returns>
        int Height();
        /// <summary>
        /// Tamaño de cada boton del casillero. Los botones siempre son cuadrados
        /// </summary>
        /// <returns>Tamaño en puntos de cada lado de los botones</returns>
        int ButtonSize();
        /// <summary>
        /// Botón del tablero ubicado en la posición indicada
        /// </summary>
        /// <param name="x">coordenas x del boton en el tablero</param>
        /// <param name="y">coordenas y del boton en el tablero</param>
        /// <returns></returns>
        IButton GetButton(int x, int y);
        /// <summary>
        /// Listado de todos los botones del tablero en una única lista
        /// </summary>
        /// <returns></returns>
        List<IButton> GetAllButtons();
    }
}
