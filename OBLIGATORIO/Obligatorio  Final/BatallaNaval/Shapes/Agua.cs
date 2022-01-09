using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio;
using System.Drawing;

namespace BatallaNaval.Shapes
{
    public class Agua
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(0, 0);
        IPoint p2 = new Point(99, 0);
        IPoint p3 = new Point(99, 99);
        IPoint p4 = new Point(0, 99);
        IPoint p5 = new Point(0, 1);

        IShape s1 = new Shape();

        public Agua()
        {
            forma = new Shape[1];

            s1.AgregarPunto(p1);
            s1.AgregarPunto(p2);
            s1.AgregarPunto(p3);
            s1.AgregarPunto(p4);
            s1.AgregarPunto(p5);

            Color Azul = Color.FromArgb(66, 134, 244);
            s1.ShapeColor = Azul;
            forma[0] = s1;
        }

    }
}
