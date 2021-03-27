using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Square : Rectangle
    {
        public Square(double width, double height) : base(width, width)
        {
        }
        public Square(double side) : base(side, side)
        {
        }
    }
}
