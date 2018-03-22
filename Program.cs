using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeDLL;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Triangle triangle = new Triangle(1, 2, 3);
            Shape unknownShape = new Shape();

            unknownShape.UnknownShape(3);
            unknownShape.UnknownShape(3, 4, 5);
            circle.ShowArea();
            triangle.ShowArea();
           
        }
    }
}
