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
    public class Mina
    {
        public IShape[] forma { get; set; } 
        IPoint p1 = new Point(13, 40);
        IPoint p2 = new Point(13, 52);
        IPoint p3 = new Point(18,66);
        IPoint p4 = new Point(26, 75);
        IPoint p5 = new Point(38, 82);
        IPoint p6 = new Point(45, 84);
        IPoint p7 = new Point(57, 84);
        IPoint p8 = new Point(68, 82);
        IPoint p9 = new Point(76, 75);
        IPoint p10 = new Point(83, 66);
        IPoint p11 = new Point(89, 52);
        IPoint p12 = new Point(89, 40);
        IPoint p13 = new Point(84, 27);
        IPoint p14 = new Point(75, 17);
        IPoint p15 = new Point(68, 10);
        IPoint p16 = new Point(57, 8);
        IPoint p17 = new Point(45, 8);
        IPoint p18 = new Point(32, 13);
        IPoint p19 = new Point(24, 19);
        IPoint p20 = new Point(17, 30);
        IPoint p21 = new Point(14, 36);
        IShape s1 = new Shape();
        
        public Mina ()
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
            Color negro = Color.FromArgb(0, 0, 0);
            s1.ShapeColor = negro;
            forma [0] = s1;
        }
        /// <summary>
        /// Función que cambia el color a una instancia de mina
        /// </summary>
        public void CambiarColor()
        {
            Color rojo = Color.FromArgb(239, 16, 16);
            s1.ShapeColor = rojo;
            forma[0] = s1;
        }
        
        
        
        
    }
}
