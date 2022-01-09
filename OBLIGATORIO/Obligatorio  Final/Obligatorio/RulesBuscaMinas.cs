using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using System.Windows.Forms;
using Obligatorio.Shapes;
using System.Drawing;

namespace Obligatorio
{
    public class RulesBuscaMinas : IRules
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
            BuscaMinasGame busca1 = BuscaMinasGame.GetInstancia();
            if (busca1.EstadoJuego.Equals(true))
            {
                if (!(busca1.ContadorVictoria == 0))
                {

                    Mina m1 = new Shapes.Mina();
                    foreach (IButton b in busca1.tablero.GetAllButtons())
                    {

                        if (b.CoordX == x && b.CoordY == y && (!(b.Pressed.Equals(true))))
                        {
                            if (b.TagObject.Equals(false))
                            {
                                int a = busca1.BombasAlrededor(b);
                                b.Pressed = true;
                                busca1.ContadorVictoria--;
                                switch (a)
                                {
                                    case 0:
                                        NumeroCero n0 = new NumeroCero();
                                        b.ButtonShape = n0.forma;
                                        break;
                                    case 1:
                                        NumeroUno n1 = new NumeroUno();
                                        b.ButtonShape = n1.forma;
                                        break;
                                    case 2:
                                        NumeroDos n2 = new NumeroDos();
                                        b.ButtonShape = n2.forma;
                                        break;
                                    case 3:
                                        NumeroTres n3 = new NumeroTres();
                                        b.ButtonShape = n3.forma;
                                        break;
                                    case 4:
                                        NumeroCuatro n4 = new NumeroCuatro();
                                        b.ButtonShape = n4.forma;
                                        break;
                                    case 5:
                                        NumeroCinco n5 = new NumeroCinco();
                                        b.ButtonShape = n5.forma;
                                        break;
                                    case 6:
                                        NumeroSeis n6 = new NumeroSeis();
                                        b.ButtonShape = n6.forma;
                                        break;
                                    case 7:
                                        NumeroSiete n7 = new NumeroSiete();
                                        b.ButtonShape = n7.forma;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            }
                            else
                            {

                                m1.CambiarColor();
                                b.ButtonShape = m1.forma;
                                MessageBox.Show("Perdiste!", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                busca1.MarcarBombas(x,y);
                                busca1.EstadoJuego = false;                                
                                break;

                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("GANASTE!", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    busca1.EstadoJuego = false;                    
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
            BuscaMinasGame busca1 = BuscaMinasGame.GetInstancia();
            if (busca1.EstadoJuego.Equals(true))
            {
                if (!(busca1.ContadorVictoria == 0))
                {
                    foreach (IButton b in busca1.tablero.GetAllButtons())
                    {

                        if (b.CoordX == x && b.CoordY == y && (!(b.Pressed.Equals(true))))
                        {
                            if (!(b.TagObject.Equals(true)))
                            {
                                Bandera ban = new Bandera();
                                b.ButtonShape = ban.forma;
                            }
                            else
                            {
                                Vacio v = new Vacio();
                                b.ButtonShape = v.forma;
                                
                                
                            }
                        }
                    }

                }
            }
        }
    }
}
