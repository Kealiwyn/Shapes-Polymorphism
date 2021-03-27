using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create objects
            Rectangle rec01 = new Rectangle(4, 3);
            DisplayInfo(rec01);

            Square sqr01 = new Square(5);
            DisplayInfo(sqr01);

            Triangle tr01 = new Triangle(6, 5);
            DisplayInfo(tr01);


            Console.ReadKey();
        }
        static void DisplayInfo(GeometricFigure figure)
        {
            Console.WriteLine($"{figure.GetType().ToString().Substring(11)} -- {figure.Width} * {figure.Height} | Area: {figure.Area}");
        }
    }
}
