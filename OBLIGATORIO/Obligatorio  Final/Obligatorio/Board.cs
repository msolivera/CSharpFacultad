using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;

namespace Obligatorio
{
    public class Board : IBoard
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int TamañoBoton { get; set; }
        public List<IButton> botones { get; set; }/***/

        public Board(int tamañoboton)
        {
            
            TamañoBoton = tamañoboton;
            botones = new List<IButton>();/***/
        }
        /// <summary>
        /// Función que crea los botones en un tablero
        /// </summary>
        /// <param name="botones">Cantidad de botones</param>
        /// <param name="ishape">Tablero</param>
        public void CrearBotones(int botones, IShape[] ishape)
        {
            Alto = botones;
            Ancho = botones;
            for (int y = 0; y < this.Alto; y++)
            {
                for (int x = 0; x < this.Ancho; x++)
                {
                    IButton b = new Button(x,y,ishape);
                    AgregarBoton(b);        
                }
            
            }

            
        }
        /// <summary>
        /// Función que agrega un boton al tablero
        /// </summary>
        /// <param name="b">Objeto boton</param>
        public void AgregarBoton(IButton b)
        {
            botones.Add(b);
        }
        /// <summary>
        /// Ancho del tablero
        /// </summary>
        /// <returns>Ancho</returns>
        public int Width()
        {
            return Ancho;
        }
        /// <summary>
        /// Alto del tablero
        /// </summary>
        /// <returns>Alto</returns>
        public int Height ()
        {

            return Alto;
        }
        /// <summary>
        /// Tamaño de los botones
        /// </summary>
        /// <returns>Tamaño del boton</returns>
        public int ButtonSize()
        {
            return TamañoBoton;
        }
        /// <summary>
        /// Función que verifica la posición de un botón
        /// </summary>
        /// <param name="a">Coordenada x</param>
        /// <param name="b">Coordenada y</param>
        /// <returns>Botón</returns>
        public IButton GetButton(int a, int b)
        {
            foreach (IButton boton in this.botones)
            {
                if (boton.CoordX == a && boton.CoordY == b)
                {
                    return boton;
                    
                }
                
            }
            throw new IndexOutOfRangeException("No existe ese boton");
            
                       
        }
        /// <summary>
        /// Función que devuelve todos los botones de unt ablero
        /// </summary>
        /// <returns>botones</returns>
        public List<IButton> GetAllButtons()
        {
            return botones;/***/
        }

    }
}
