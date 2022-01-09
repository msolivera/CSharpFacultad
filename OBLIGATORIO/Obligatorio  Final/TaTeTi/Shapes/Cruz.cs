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
    public class Cruz
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(10, 1);
        IPoint p2 = new Point(11, 1);
        IPoint p3 = new Point(49, 39);
        IPoint p4 = new Point(50, 39);
        IPoint p5 = new Point(88, 1);
        IPoint p6 = new Point(89, 1);
        IPoint p7 = new Point(60, 49);
        IPoint p8 = new Point(60, 50);
        IPoint p9 = new Point(98, 88);
        IPoint p10 = new Point(98, 89);
        IPoint p11 = new Point(89, 98);
        IPoint p12 = new Point(88, 98);
        IPoint p13 = new Point(50, 60);
        IPoint p14 = new Point(49, 60);
        IPoint p15 = new Point(11, 98);
        IPoint p16 = new Point(10, 98);
        IPoint p17 = new Point(39, 50);
        IPoint p18 = new Point(39, 49);
        IPoint p19 = new Point(1, 11);
        IPoint p20 = new Point(1, 10);
        IPoint p21 = new Point(9, 2);

        IShape s1 = new Shape();

        public Cruz()
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
            Color rojo = Color.FromArgb(244, 65, 65);
            s1.ShapeColor = rojo;
            forma[0] = s1;
        }
    }
}
