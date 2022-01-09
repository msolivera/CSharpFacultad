using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio.Shapes;
using System.Windows.Forms;




namespace Obligatorio
{
    public class BuscaMinasGame
    {
        private static BuscaMinasGame instancia = null;
        public IBoard tablero { get; set; }
        
        public bool EstadoJuego { get; set; }
        public Mina bomb { get; set; }
        public int ContadorVictoria { get; set; }
        public IRules r1 = new RulesBuscaMinas();
        public List<String> bombas { get; set; }
        

        private BuscaMinasGame()
        {
            bomb = new Mina();
            EstadoJuego = true;
            tablero = new Board(30);
            ContadorVictoria = 54;
            
            bombas = new List<String>(GeneradorBombas());

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
        public static BuscaMinasGame GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new BuscaMinasGame();
            }
            return instancia;
        }


        /// <summary>
        /// Genera un nuevo tablero y elije al azar un "preset" con los barcos distribuidos.
        /// </summary>
        public void GenerarJuego()
        {
            Vacio v = new Vacio();           
            tablero.CrearBotones(8, v.forma);
            
            
            foreach (IButton b in tablero.GetAllButtons())
            {
                
                foreach (String mina in bombas)
                {
                    string[] coords = mina.Split(',');
                    if (b.CoordX.ToString().Equals(coords[0]) && b.CoordY.ToString().Equals(coords[1]))
                    {
                        
                        b.TagObject = bomb;
                        break;
                      
                    }
                    else
                    {
                        b.TagObject = false;
                        
                    }
                }            
            }
            


        }
        /// <summary>
        /// Función que genera minas en el tablero de forma aleatoria.
        /// </summary>
        /// <returns>Lista de bombas</returns>
        public List<String> GeneradorBombas()
        {
            List<String> usados = new List<String>();
            string ran;
            int i = 0;
            Random random = new Random();
            while ( i<10)
            {
                int randomx = 0;
                int randomy = 0;
                randomx = random.Next(0, 8);
                randomy = random.Next(0, 8);
                ran = randomx.ToString() +","+ randomy.ToString();
                if (!(i == 0))
                {
                    int contador = 0;
                    foreach (String s in usados)
                    {
                        if (s == ran)
                        {
                            contador += 1;
                            break;
                        }
                        
                    }
                    if (contador == 0)
                    {
                        usados.Add(randomx.ToString() +","+ randomy.ToString());
                        i++;
                    }
                }
                if (i == 0)
                {
                    usados.Add(randomx.ToString() +","+ randomy.ToString());
                    i++;
                }
                
                

            }
            return usados; 
        }
        /// <summary>
        /// Función que verifica si hay un boton con una mina a cierta distancia del boton presionado.
        /// </summary>
        /// <param name="x">Coordenada x del boton presionado</param>
        /// <param name="y">Coordenada y del boton presionado</param>
        /// <param name="xn">Diferencia de posición en x del boton presionado</param>
        /// <param name="yn">Diferencia de posición en y del boton presionado</param>
        /// <returns>Un booleano que determina si la posición solicitada tiene una mina</returns>
        public bool VerificarBomba(int x, int y , int xn, int yn)
        {
           
            List<IButton> botones = tablero.GetAllButtons();
            foreach (IButton bot in botones)
            {
                if ((bot.CoordX == (x + xn)) && (bot.CoordY == (y + yn)))
                {
                    if (bot.TagObject is Shapes.Mina)
                    {
                        return true;
                    }
                    
                }

            }
            return false;
        }
        /// <summary>
        /// Función que, utilizando "Verificar bomba" devuelve la cantidad de botones con bombas alrededor del boton presionado.
        /// </summary>
        /// <param name="b">Boton presionado</param>
        /// <returns>Cantidad de bombas alrededor</returns>
        public int BombasAlrededor(IButton b)
        {
            int x = b.CoordX;
            int y = b.CoordY;
            int contador = 0;
            List<IButton> botones = tablero.GetAllButtons();
            if (VerificarBomba(x, y, -1, -1).Equals(true))
            {
                contador++;
            }
            if (VerificarBomba(x, y, 0, -1).Equals(true))
            {
                contador++;
            }
            if (VerificarBomba(x, y, 1, -1).Equals(true))
            {
                contador++;
            }
            if (VerificarBomba(x, y, 1, 0).Equals(true))
            {
                contador++;
            }
            if (VerificarBomba(x, y, 1, 1).Equals(true))
            {
                contador++;
            }
            if (VerificarBomba(x, y, 0, 1).Equals(true))
            {
                contador++;
            }
            if (VerificarBomba(x, y, -1, 1).Equals(true))
            {
                contador++;
            }
            if (VerificarBomba(x, y, -1, 0).Equals(true))
            {
                contador++;
            }
            return contador;

        }
        
        /// <summary>
        /// Función que marca las bombas en el tablero menos la presionada.
        /// </summary>
        /// <param name="x">Coordenada x</param>
        /// <param name="y">Coordenada y</param>
        public void MarcarBombas(int x , int y)
        {

            List<IButton> botones = tablero.GetAllButtons();
            foreach (IButton bot in botones)
            {                
                if (bot.TagObject is Shapes.Mina)
                {
                    if (bot.CoordX == x && bot.CoordY == y)
                    {
                        //No hace nada
                    }
                    else
                    {
                        Mina m1 = new Mina();
                        bot.ButtonShape = m1.forma;
                    }
                }               

            }
            
        }








    }
}
