using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using System.Windows.Forms;
using TaTeTi.Shapes;
using BatallaNaval.Shapes;

namespace BatallaNaval
{
    public class RulesBatallaNaval : IRules
    {
        /// <summary>
        /// Función que determina que hace el clic izquierdo en el juego
        /// </summary>
        /// <param name="x">Coordenada x</param>
        /// <param name="y">Coordenada y</param>
        /// <param name="board">Tablero</param>
        /// <param name="seconds">Segundo en que el boton es presionado</param>
        public void ButtonPressed(int x, int y, IBoard board, int seconds)
        {
            BatallaNavalGame bat1 = BatallaNavalGame.GetInstancia();
            
            if (bat1.EstadoJuego.Equals(true))
            {
                
                foreach (IButton b in bat1.tablero.GetAllButtons())
                {
                    if (b.CoordX == x && b.CoordY == y && (b.Pressed.Equals(false)))
                    {
                        if (b.TagObject.Equals(true))
                        {
                            Cruz c1 = new Cruz();
                            b.Pressed = true;
                            bat1.Balas--;
                            b.ButtonShape = c1.forma;
                            bat1.ContadorVictoria--;
                            bat1.VerficarVictoria();
                            break;
                        }
                        else
                        {
                            Agua a1 = new Shapes.Agua();
                            b.Pressed = true;
                            b.ButtonShape = a1.forma;
                            bat1.Balas--;
                            bat1.VerficarVictoria();
                            break;
                        }
                    }
                }
            }   
            
        }
        /// <summary>
        /// Función que determina que hace el clic derecho en el juego
        /// </summary>
        /// <param name="x">Coordenada x</param>
        /// <param name="y">Coordenada y</param>
        /// <param name="board">Tablero</param>
        /// <param name="seconds">Segundo en que el boton es presionado</param>
        public void ButtonPressedRight(int x, int y, IBoard board, int seconds)
        {
            //No hace nada
        }
    }
}
