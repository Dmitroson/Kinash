using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kinash_2_1
{
    public class ShapeChange
    {
        public Pen BlackPen;
        public Pen RedPen;
        public Rectangle square;

        public ShapeChange()
        {
            BlackPen = new Pen(Color.Black, 3);
            RedPen = new Pen(Color.Red, 3);
            square = new Rectangle(50, 50, 100, 100);
        }


    }
}
