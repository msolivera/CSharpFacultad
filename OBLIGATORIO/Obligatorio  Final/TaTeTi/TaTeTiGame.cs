using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio.Shapes;
using System.Windows.Forms;
using TaTeTi.Shapes;

namespace TaTeTi
{
    public class TaTeTiGame
    {
        private static TaTeTiGame instancia = null;
        public IBoard tablero { get; set; }
        public IShape[] formas { get; set; }
        public bool EstadoJuego { get; set; }
        public int ContadorVictoria { get; set; }
        public IRules r1 = new RulesTaTeTi();
        public Boolean jugador = true;
        

        public TaTeTiGame()
        {
            EstadoJuego = true;
            tablero = new Board(100);
            
        }
        /// <summary>
        /// Función que reinicia la instancia de la clase para poder jugarse un nuevo juego al cerrar y volver a abrir la ventana.
        /// </summary>
        public void SetInstancia()
        {
            instancia = null;
        }
        /// <summary>
        /// Crea una instancia única de la clase con la cual se trabajará hasta eliminarse dicha instancia.
        /// </summary>
        /// <returns>Instancia</returns>
        public static TaTeTiGame GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new TaTeTiGame();

            }
            return instancia;
        }
        /// <summary>
        /// Genera un nuevo tablero vacío.
        /// </summary>
        public void GenerarJuego()
        {
            Vacio c = new Vacio();
            tablero.CrearBotones(3, c.forma);
            foreach (IButton boton in tablero.GetAllButtons())
            {
                boton.TagObject = "vacio";
            }


        } 
        /// <summary>
        /// Función que realiza un "cambio de jugador" una vez que uno de ellos juega su turno.
        /// </summary>
        public void CambiarJugador ()
        {
            if(EstadoJuego.Equals(true))
            {
                if(jugador.Equals(true))
                {
                    jugador = false;
                }
                else
                {
                    jugador = true;
                }
            }
        }
        /// <summary>
        /// Función que verifica que símbolo hay sobre un botón (Cruz o círculo)
        /// </summary>
        /// <param name="boton"></param>
        /// <returns>Booleano que, si es true significa que es una cruz, y si es false, un circulo</returns>
        public Boolean VerficaSimbolo(IButton boton)
        {
            if (boton.TagObject.Equals("cruz"))
            {
                return true;
            }
            else
            {          
                return false;
            }
           
        }
        /// <summary>
        /// Verifica si un juego sigue en curso, si uno de los jugadores ganó o si el juego terminó en empate.
        /// </summary>
        public void VerificarJuego()
        {

            List<IButton> lista = tablero.GetAllButtons();
            if (lista.ElementAt(0).TagObject.Equals(lista.ElementAt(3).TagObject) && lista.ElementAt(0).TagObject.Equals(lista.ElementAt(6).TagObject) && lista.ElementAt(0).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(0).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }

            }
            if (lista.ElementAt(1).TagObject.Equals(lista.ElementAt(4).TagObject) && lista.ElementAt(1).TagObject.Equals(lista.ElementAt(7).TagObject) && lista.ElementAt(1).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(1).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            if (lista.ElementAt(2).TagObject.Equals(lista.ElementAt(5).TagObject) && lista.ElementAt(2).TagObject.Equals(lista.ElementAt(8).TagObject) && lista.ElementAt(2).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(2).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            if (lista.ElementAt(0).TagObject.Equals(lista.ElementAt(1).TagObject) && lista.ElementAt(0).TagObject.Equals(lista.ElementAt(2).TagObject) && lista.ElementAt(0).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(0).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            if (lista.ElementAt(3).TagObject.Equals(lista.ElementAt(4).TagObject) && lista.ElementAt(3).TagObject.Equals(lista.ElementAt(5).TagObject) && lista.ElementAt(3).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(3).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            if (lista.ElementAt(6).TagObject.Equals(lista.ElementAt(7).TagObject) && lista.ElementAt(6).TagObject.Equals(lista.ElementAt(8).TagObject) && lista.ElementAt(6).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(6).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            if (lista.ElementAt(0).TagObject.Equals(lista.ElementAt(4).TagObject) && lista.ElementAt(0).TagObject.Equals(lista.ElementAt(8).TagObject) && lista.ElementAt(0).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(0).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            if (lista.ElementAt(2).TagObject.Equals(lista.ElementAt(4).TagObject) && lista.ElementAt(2).TagObject.Equals(lista.ElementAt(6).TagObject) && lista.ElementAt(2).TagObject != "vacio")
            {
                EstadoJuego = false;

                if (lista.ElementAt(2).TagObject.ToString() == "cruz")
                {
                    MessageBox.Show("Ganador: JUGADOR 1", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Ganador: JUGADOR 2", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }


            }
            else
            {
                int contador = 0;
                foreach (IButton B in tablero.GetAllButtons())
                {
                    if (!(B.TagObject.Equals("vacio")))
                    {
                        contador++;
                    }
                }
                if (contador == 9)
                {
                    MessageBox.Show("¡Buena batalla! Pero no ha ganado nadie :(", "Empate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }

            }
      
            


        }

    }
}
