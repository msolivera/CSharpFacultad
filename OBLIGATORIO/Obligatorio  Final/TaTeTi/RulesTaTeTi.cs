using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio.Shapes;
using System.Drawing;
using TaTeTi.Shapes;


namespace TaTeTi
{
    public class RulesTaTeTi:IRules
    {
        /// <summary>
        /// Accion de in click Izquierdo
        /// </summary>
        /// <param name="x">Coordenada x del boton en el tablero</param>
        /// <param name="y">Coordenada y del boton en el tablero</param>
        /// <param name="board"> Tablero del juego</param>
        /// <param name="seconds"> Tiempo que transcurre desde que comienza el juego</param>
        public void ButtonPressed(int x, int y, IBoard board, int seconds)
        {
            TaTeTiGame tateti = TaTeTiGame.GetInstancia();

            if (tateti.EstadoJuego.Equals(true))
            {

                if (tateti.jugador.Equals(true))
                {
                    foreach (IButton boton in tateti.tablero.GetAllButtons())
                    {
                        if ((boton.CoordX == x) && (boton.CoordY == y) && boton.Pressed.Equals(false))
                        {

                            Cruz cruz = new Cruz();
                            boton.ButtonShape = cruz.forma;
                            tateti.CambiarJugador();
                            boton.Pressed = true;
                            boton.TagObject = "cruz";
                            tateti.VerificarJuego();                            
                            break;
                        }


                    }
                }
                else
                {
                    foreach (IButton boton in tateti.tablero.GetAllButtons())
                    {
                        if ((boton.CoordX == x) && (boton.CoordY == y) && boton.Pressed.Equals(false))
                        {
                            Circulo circulo = new Circulo();
                            boton.ButtonShape = circulo.forma;
                            tateti.CambiarJugador();
                            boton.Pressed = true;
                            boton.TagObject = "circulo";
                            tateti.VerificarJuego();
                            break;
                        }


                    }

                }
            }
           

        }
        /// <summary>
        /// Accion de in click derecho
        /// </summary>
        /// <param name="x">Coordenada x del boton en el tablero</param>
        /// <param name="y">Coordenada y del boton en el tablero</param>
        /// <param name="board"> Tablero del juego</param>
        /// <param name="seconds"> Tiempo que transcurre desde que comienza el juego</param>
        public void ButtonPressedRight(int x, int y, IBoard board, int seconds)
        {
           
            //no se usa en este juego

        }
    }
}
