using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    abstract class GeometricFigure
    {
        private double width;
        private double height;
        protected double area;

        public double Width
        {
            get { return width; }
            set { width = value; ComputeArea(); }
        }
        public double Height
        {
            get { return height; }
            set { height = value; ComputeArea(); }
        }
        public double Area
        {
            get { return area; }
        }

        public GeometricFigure(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public abstract void ComputeArea();
    }
}
