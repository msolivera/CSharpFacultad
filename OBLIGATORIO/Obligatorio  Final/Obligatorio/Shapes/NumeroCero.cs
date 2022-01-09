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
    public class NumeroCero
    {
        public IShape[] forma { get; set; }
        IPoint p1 = new Point(31, 26);
        IPoint p2 = new Point(55, 26);
        IPoint p3 = new Point(55, 61);
        IPoint p4 = new Point(50, 61);
        IPoint p5 = new Point(50, 31);
        IPoint p6 = new Point(36, 31);
        IPoint p7 = new Point(36, 56);
        IPoint p8 = new Point(49, 56);
        IPoint p9 = new Point(49, 61);
        IPoint p10 = new Point(31, 61);
        IPoint p11 = new Point(31, 27);
    
   

        IShape s3 = new Shape();

        public NumeroCero()
        {
            forma = new Shape[1];

            s3.AgregarPunto(p1);
            s3.AgregarPunto(p2);
            s3.AgregarPunto(p3);
            s3.AgregarPunto(p4);
            s3.AgregarPunto(p5);
            s3.AgregarPunto(p6);
            s3.AgregarPunto(p7);
            s3.AgregarPunto(p8);
            s3.AgregarPunto(p9);
            s3.AgregarPunto(p10);
            s3.AgregarPunto(p11);

            Color negro = Color.FromArgb(122, 79, 0);
            s3.ShapeColor = negro;
            forma[0] = s3;
        }
    }
}
