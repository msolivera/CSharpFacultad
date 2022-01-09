using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio.Shapes;
using System.Windows.Forms;
namespace BatallaNaval
{
    public class BatallaNavalGame
    {
        private static BatallaNavalGame instancia = null;
        public IBoard tablero { get; set; }
        public IShape[] formas { get; set; }
        public bool EstadoJuego { get; set; }
        public int Balas { get; set; }
        public int ContadorVictoria { get; set; }
        public IRules r1 = new RulesBatallaNaval();
        public List<String> barcos { get; set; }

        public BatallaNavalGame()
        {

            EstadoJuego = true;
            tablero = new Board(30);
            ContadorVictoria = 19;
            Balas = 40;


        }
        
        /// <summary>
        /// Función que verifica si el juego ha finalizado, ya sea por haber ganado o por haber perdido (quedarse sin balas).
        /// </summary>
        public void  VerficarVictoria()
        {
            if (ContadorVictoria == 0)
            {
                if (!(this.Balas == 0))
                {
                    this.EstadoJuego = false;
                    
                    MessageBox.Show("¡Has ganado! ¡Enhorabuena!", "Felicidades..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
                
                
            }
            if (this.Balas == 0)
            {
                this.EstadoJuego = false;
                
                MessageBox.Show("Has perdido, te has quedado sin balas :(", "¡Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

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
        public static BatallaNavalGame GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new BatallaNavalGame();
            }
            return instancia;
        }
        /// <summary>
        /// Genera un nuevo tablero y elije al azar un "preset" con los barcos distribuidos.
        /// </summary>
        public void GenerarJuego()
        {
            Vacio v1 = new Vacio();
            tablero.CrearBotones(10, v1.forma);
            foreach (IButton b in tablero.GetAllButtons())
            {
                b.TagObject = false;
            }
            Random r = new Random();
            int a = r.Next(1, 5);
            if (a==1)
            {
                Preset1();
            }
            if (a==2)
            {
                Preset2();
            }
            if (a==3)
            {
                Preset3();
            }
            if (a==4)
            {
                Preset4();
            }
            
      


        }
        /// <summary>
        /// Preset para la distribución de los barcos en el tablero
        /// </summary>
        public void Preset1()
        {

            int[] x = new int[] { 1, 4, 4, 4, 6, 7, 8, 9, 0, 1, 7, 1, 1, 4, 4, 3, 4, 5, 6, 9 };
            int[] y = new int[] { 1, 0, 1, 2, 0, 1, 1, 1, 4, 4, 4, 6, 7, 5, 6, 8, 8, 8, 8, 9 };            
            for (int i = 0; i < 20; i++)
            {
                foreach (IButton b in tablero.GetAllButtons())
                {
                    if (b.CoordX.Equals(x[i]) && b.CoordY.Equals(y[i]))
                    {
                        b.TagObject = true;
                        break;

                    }

                }
            }
            
        }
        /// <summary>
        /// Preset para la distribución de los barcos en el tablero
        /// </summary>
        public void Preset2()
        {
            int[] x = new int[] {0,0,0,0,0,0,0,2,2,4,7,8,3,3,3,6,2,7,8,9};
            int[] y = new int[] {0,1,2,3,5,6,7,0,1,0,0,0,3,4,5,3,8,7,5,5};
            for (int i = 0; i < 20; i++)
            {
                foreach (IButton b in tablero.GetAllButtons())
                {
                    if (b.CoordX.Equals(x[i]) && b.CoordY.Equals(y[i]))
                    {
                        b.TagObject = true;
                        break;

                    }

                }
            }

        }
        /// <summary>
        /// Preset para la distribución de los barcos en el tablero
        /// </summary>
        public void Preset3()
        {
            int[] x = new int[] {0,1,2,2,5,5,7,8,8,8,1,1,3,4,5,6,2,5,6,6};
            int[] y = new int[] {1,1,1,3,2,3,1,2,3,4,5,6,5,5,5,5,8,7,7,9};
            for (int i = 0; i < 20; i++)
            {
                foreach (IButton b in tablero.GetAllButtons())
                {
                    if (b.CoordX.Equals(x[i]) && b.CoordY.Equals(y[i]))
                    {
                        b.TagObject = true;
                        break;

                    }

                }
            }

        }
        /// <summary>
        /// Preset para la distribución de los barcos en el tablero
        /// </summary>
        public void Preset4()
        {
            int[] x = new int[] {1,3,4,1,2,3,6,6,6,6,8,3,1,1,3,4,5,7,7,5 };
            int[] y = new int[] {0,0,0,2,2,2,1,2,3,4,3,4,6,7,6,6,6,6,7,8 };
            for (int i = 0; i < 20; i++)
            {
                foreach (IButton b in tablero.GetAllButtons())
                {
                    if (b.CoordX.Equals(x[i]) && b.CoordY.Equals(y[i]))
                    {
                        b.TagObject = true;
                        break;

                    }

                }
            }

        }

    }

}


     

