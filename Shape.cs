using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDLL
{
    public class Shape
    {
        public double Area { get; set; }


        public virtual void ShowArea()
        {
            Console.WriteLine("Shape area is " + Area);
        }
        
        
        public void UnknownShape(double r) // Если фигура не известна будем определять ее по входным данным
        {
            Circle circle = new Circle(r);
            circle.ShowArea();
        }

        public void UnknownShape(double s1,double s2,double s3)
        {
            Triangle triangle = new Triangle(s1, s2, s3);
            triangle.ShowArea();
        }

        

    }

    public class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(double r) 
        {
            
            if(r == 0)
                Console.WriteLine("Radius of the circle can not be 0, fill the radius correctly");
            else
                Radius = r;
                
        }
       
        public double CalcArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }

        public override void ShowArea()
        {
            CalcArea();

            if(Area != 0)
                Console.WriteLine("Circle area is " + "{0:0.##}", Area);
            else
                Console.WriteLine(0);
        }

        public bool TestForNULL(double v)
        {
            Circle circle = new Circle(v);
            if (circle.CalcArea() == 0)
                return false;
            else
                return true;
        }
        
    }

    public class Triangle : Shape
    {
        double Side1 { get; set; }
        double Side2 { get; set; }
        double Side3 { get; set; }

        public Triangle(double s1,double s2,double s3) 
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }

        public double CalcArea()
        {
            double p;
            p = (Side1 + Side2 + Side3) /2;
            Area = Math.Sqrt(p*(p - Side1) * (p - Side2) * (p - Side3));

            if (Math.Pow(Side3, 2) == (Math.Pow(Side1, 2) + Math.Pow(Side2, 2)))
                Console.WriteLine("The triangle is rectangular");
            return Area;
        }

        public override void ShowArea()
        {
            CalcArea();

            if (Area != 0)
                Console.WriteLine("Triangle area is " + "{0:0.##}", Area);
            else
                Console.WriteLine("the sides of the triangle are not set correctly");
        }


        public bool TestForNULL(double s1,double s2,double s3)
        {
            Triangle triangle = new Triangle(s1,s2,s3);
            if (triangle.CalcArea() == 0)
                return false;
            else
                return true;
        }

    }
}
