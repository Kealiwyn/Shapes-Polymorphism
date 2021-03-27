using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Rectangle : GeometricFigure
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override void ComputeArea()
        {
            area = Width * Height;
        }
    }
}
