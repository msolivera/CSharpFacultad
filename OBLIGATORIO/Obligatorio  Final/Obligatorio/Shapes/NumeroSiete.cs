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
    public class NumeroSiete
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(31, 26);
        IPoint p2 = new Point(55, 26);
        IPoint p3 = new Point(55, 61);
        IPoint p4 = new Point(50, 61);
        IPoint p5 = new Point(50, 31);
        IPoint p6 = new Point(31, 31);
        IPoint p7 = new Point(31, 27);




        IShape s5 = new Shape();

        public NumeroSiete()
        {
            forma = new Shape[1];

            s5.AgregarPunto(p1);
            s5.AgregarPunto(p2);
            s5.AgregarPunto(p3);
            s5.AgregarPunto(p4);
            s5.AgregarPunto(p5);
            s5.AgregarPunto(p6);
            s5.AgregarPunto(p7);

            Color negro = Color.FromArgb(0, 0, 0);
            s5.ShapeColor = negro;
            forma[0] = s5;
        }
    }
}