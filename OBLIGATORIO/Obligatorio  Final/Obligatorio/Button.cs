using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaMinas;
using System.Drawing;

namespace Obligatorio
{
    public class Button : IButton
    {
        
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public IShape[] ButtonShape { get; set; }
        public object TagObject { get; set; }
        public bool Pressed { get; set; }
       
        public Button(int x, int y, IShape[] shaps)
        {
            CoordX = x;
            CoordY = y;
            ButtonShape = shaps;
            

        }
        





    }
}
