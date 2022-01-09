using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BatallaNaval
{
    public class Program
    {
        static void Main(string[] args)
        {
            BatallaNavalGame b1 = BatallaNavalGame.GetInstancia();
            
            b1.GenerarJuego();
        }
    }
}
