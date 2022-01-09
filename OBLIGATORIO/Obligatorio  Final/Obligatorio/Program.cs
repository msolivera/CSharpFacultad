using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuscaMinas;

namespace Obligatorio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {

            
            
            BuscaMinasGame b1 = BuscaMinasGame.GetInstancia();
            
            b1.GenerarJuego();
            //
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI(b1.tablero, r));



        }
    }
}
