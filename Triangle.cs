using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Triangle : GeometricFigure
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override void ComputeArea()
        {
            area = Width * Height / 2;
        }
    }
}
