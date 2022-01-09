using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BuscaMinas
{
    /// <summary>
    /// Representa un casillero del tablero. Cada casillero se representa mediante un boton.
    /// Cada botón deberá contener una lista de figuras que son dibujadas en pantalla.
    /// </summary>
    public interface IButton
    {

        int CoordX { get; set; }
        int CoordY { get; set; }
        /// <summary>
        /// Listado de figuras que confirman la representación gráfica del botón
        /// </summary>

        IShape[] ButtonShape { get; set; }
        /// <summary>
        /// Objeto asociado al botón con información adicional para cada juego.
        /// </summary>
        object TagObject { get; set; }
        /// <summary>
        /// Indicador de estado para saber si el boton fue presionado.
        /// </summary>
        bool Pressed { get; set; }

        
       
    }
}
