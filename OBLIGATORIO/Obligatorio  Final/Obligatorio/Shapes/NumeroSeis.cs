﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using Obligatorio;
using System.Drawing;

namespace Obligatorio.Shapes
{
    public class NumeroSeis
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(31, 26);
        IPoint p2 = new Point(36, 26);
        IPoint p3 = new Point(36, 56);
        IPoint p4 = new Point(50, 56);
        IPoint p5 = new Point(50, 46);      
        IPoint p6 = new Point(37, 46);
        IPoint p7 = new Point(37, 42);
        IPoint p8 = new Point(55, 42);
        IPoint p9 = new Point(55, 61);
        IPoint p10 = new Point(55, 61);
        IPoint p11 = new Point(31, 61);
        IPoint p12 = new Point(31, 27);



        IShape s5 = new Shape();

        public NumeroSeis()
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


            Color negro = Color.FromArgb(140, 14, 14);
            s5.ShapeColor = negro;
            forma[0] = s5;
        }
    }
}