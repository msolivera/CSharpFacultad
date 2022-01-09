using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    /// <summary>
    /// Representa las reglas de cada juego
    /// </summary>
    public interface IRules
    {
        /// <summary>
        /// Comportamiento del juego cuando se hace click izquierdo sobre un casillero/botón
        /// </summary>
        /// <param name="x">coordena x del boton en el tablero</param>
        /// <param name="y">coordena y del boton en el tablero</param>
        /// <param name="board">Tablero sobre el cual se presiono un boton</param>
        /// <param name="seconds">Tiempo transcurrido desde que comenzó el juego</param>
        void ButtonPressed(int x, int y, IBoard board, int seconds);
        /// <summary>
        /// Comportamiento del juego cuando se hace click derecho sobre un casillero/botón
        /// </summary>
        /// <param name="x">coordena x del boton en el tablero</param>
        /// <param name="y">coordena y del boton en el tablero</param>
        /// <param name="board">Tablero sobre el cual se presiono un boton</param>
        /// <param name="seconds">Tiempo transcurrido desde que comenzó el juego</param>
        void ButtonPressedRight(int x, int y, IBoard board, int seconds);
    }
}
