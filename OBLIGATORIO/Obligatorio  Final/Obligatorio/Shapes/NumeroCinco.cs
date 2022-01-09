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
    public class NumeroCinco
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(31, 26);
        IPoint p2 = new Point(55, 26);
        IPoint p3 = new Point(55, 31);
        IPoint p4 = new Point(36, 31);
        IPoint p5 = new Point(36, 42);
        IPoint p6 = new Point(55, 42);
        IPoint p7 = new Point(55, 61);
        IPoint p8 = new Point(31, 61);
        IPoint p9 = new Point(31, 56);
        IPoint p10 = new Point(50, 56);
        IPoint p11 = new Point(50, 46);
        IPoint p12 = new Point(31, 46);
        IPoint p13 = new Point(31, 27);



        IShape s5 = new Shape();

        public NumeroCinco()
        {
            forma = new Shape[1];

            s5.AgregarPunto(p1);
            s5.AgregarPunto(p2);
            s5.AgregarPunto(p3);
            s5.AgregarPunto(p4);
            s5.AgregarPunto(p5);
            s5.AgregarPunto(p6);
            s5.AgregarPunto(p7);
            s5.AgregarPunto(p8);
            s5.AgregarPunto(p9);
            s5.AgregarPunto(p10);
            s5.AgregarPunto(p11);
            s5.AgregarPunto(p12);
            s5.AgregarPunto(p13);


            Color negro = Color.FromArgb(0, 0, 0);
            s5.ShapeColor = negro;
            forma[0] = s5;
        }
    }
}