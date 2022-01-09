using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio;
using System.Drawing;

namespace TaTeTi.Shapes
{
    public class Circulo
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(47, 93);
        IPoint p2 = new Point(23, 93);
        IPoint p3 = new Point(7, 77);
        IPoint p4 = new Point(7, 20);
        IPoint p5 = new Point(23, 4);
        IPoint p6 = new Point(74, 4);
        IPoint p7 = new Point(90, 20);
        IPoint p8 = new Point(90, 77);
        IPoint p9 = new Point(74, 93);
        IPoint p10 = new Point(48, 93);
        IPoint p11 = new Point(48, 76);
        IPoint p12 = new Point(66, 76);
        IPoint p13 = new Point(74, 68);
        IPoint p14 = new Point(74, 30);
        IPoint p15 = new Point(64, 20);
        IPoint p16 = new Point(33, 20);
        IPoint p17 = new Point(23, 30);
        IPoint p18 = new Point(23, 68);
        IPoint p19 = new Point(31, 76);
        IPoint p20 = new Point(47, 76);
        IPoint p21 = new Point(47, 92);

        IShape s1 = new Shape();

        public Circulo()
        {
            forma = new Shape[1];
            s1.AgregarPunto(p1);
            s1.AgregarPunto(p2);
            s1.AgregarPunto(p3);
            s1.AgregarPunto(p4);
            s1.AgregarPunto(p5);
            s1.AgregarPunto(p6);
            s1.AgregarPunto(p7);
            s1.AgregarPunto(p8);
            s1.AgregarPunto(p9);
            s1.AgregarPunto(p10);
            s1.AgregarPunto(p11);
            s1.AgregarPunto(p12);
            s1.AgregarPunto(p13);
            s1.AgregarPunto(p14);
            s1.AgregarPunto(p15);
            s1.AgregarPunto(p16);
            s1.AgregarPunto(p17);
            s1.AgregarPunto(p18);
            s1.AgregarPunto(p19);
            s1.AgregarPunto(p20);
            s1.AgregarPunto(p21);


            Color Azul = Color.FromArgb(66, 134, 244);
            s1.ShapeColor = Azul;
            forma[0] = s1;
        }

    }
}
