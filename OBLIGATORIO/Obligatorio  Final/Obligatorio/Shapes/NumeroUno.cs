using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio;
using System.Drawing;

namespace Obligatorio.Shapes
{
    public class NumeroUno
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(41, 26);
        IPoint p2 = new Point(45, 26);
        IPoint p3 = new Point(45, 61);
        IPoint p4 = new Point(41, 61);
        IPoint p5 = new Point(41, 27);


        IShape s4 = new Shape();

        public NumeroUno()
        {
            forma = new Shape[1];

            s4.AgregarPunto(p1);
            s4.AgregarPunto(p2);
            s4.AgregarPunto(p3);
            s4.AgregarPunto(p4);
            s4.AgregarPunto(p5);


            Color negro = Color.FromArgb(0, 102, 102);
            s4.ShapeColor = negro;
            forma[0] = s4;
        }
    }
}
