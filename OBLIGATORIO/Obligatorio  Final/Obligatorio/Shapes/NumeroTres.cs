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
    public class NumeroTres
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(31, 26);
        IPoint p2 = new Point(55, 26);
        IPoint p3 = new Point(55, 61);
        IPoint p4 = new Point(31, 61);
        IPoint p5 = new Point(31, 56);
        IPoint p6 = new Point(50, 56);
        IPoint p7 = new Point(50, 46);
        IPoint p8 = new Point(37, 46);
        IPoint p9 = new Point(37, 42);
        IPoint p10 = new Point(50, 42);
        IPoint p11 = new Point(50, 31);
        IPoint p12 = new Point(31, 31);
        IPoint p13 = new Point(31, 27);



        IShape s6 = new Shape();

        public NumeroTres()
        {
            forma = new Shape[1];

            s6.AgregarPunto(p1);
            s6.AgregarPunto(p2);
            s6.AgregarPunto(p3);
            s6.AgregarPunto(p4);
            s6.AgregarPunto(p5);
            s6.AgregarPunto(p6);
            s6.AgregarPunto(p7);
            s6.AgregarPunto(p8);
            s6.AgregarPunto(p9);
            s6.AgregarPunto(p10);
            s6.AgregarPunto(p11);
            s6.AgregarPunto(p12);
            s6.AgregarPunto(p13);


            Color negro = Color.FromArgb(39, 140, 14);
            s6.ShapeColor = negro;
            forma[0] = s6;
        }
    }
}