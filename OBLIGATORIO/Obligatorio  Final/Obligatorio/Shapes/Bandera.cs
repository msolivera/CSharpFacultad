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
    public class Bandera
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(31, 23);//
        IPoint p2 = new Point(35, 23);
        IPoint p3 = new Point(35, 26);
        IPoint p4 = new Point(69, 26);
        IPoint p5 = new Point(69, 48);
        IPoint p6 = new Point(35, 48);
        IPoint p7 = new Point(35, 77);
        IPoint p8 = new Point(31, 77);
        IPoint p9 = new Point(31, 23);
       

        IShape s2 = new Shape();

        public Bandera()
        {
            forma = new Shape[1];
            s2.AgregarPunto(p1);
            s2.AgregarPunto(p2);
            s2.AgregarPunto(p3);
            s2.AgregarPunto(p4);
            s2.AgregarPunto(p5);
            s2.AgregarPunto(p6);
            s2.AgregarPunto(p7);
            s2.AgregarPunto(p8);
            s2.AgregarPunto(p9);
            
            Color rojo = Color.FromArgb(244, 66, 66);
            s2.ShapeColor = rojo;
            forma[0] = s2;
        }
    }
}
