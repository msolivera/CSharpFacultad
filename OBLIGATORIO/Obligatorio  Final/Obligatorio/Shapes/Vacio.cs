using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio;

namespace Obligatorio.Shapes
{
    public class Vacio
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(0, 0);
        IPoint p2 = new Point(0, 1);
        IShape sv = new Shape();

        public Vacio()
        {
            forma = new Shape[1];
            sv.AgregarPunto(p1);
            sv.AgregarPunto(p2);
            forma[0] = sv;
        }
        
       

    }
}
