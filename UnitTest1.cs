using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeDLL;

namespace UnitTestShapeDLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForNullValueCircle()
        {
            double[] radiusTest = { 2, 3, 0, 5, 6, 6, 7, 8 }; // изменть ноль на другое значение и тест будет выполнен
            Circle circle;
            foreach(var value in radiusTest)
            {
                circle = new Circle(value);
                bool result = circle.TestForNULL(value);
                Assert.IsTrue(result, "Expected not NULL value; Actual : {0}", value, result);
            }
        
        }

        [TestMethod]
        public void TestForNullValueTriangle()
        {
            TrianglesValues t1 = new TrianglesValues(1, 2, 3); // изменить на на правильно значение и тест будет выполнен
            TrianglesValues t2 = new TrianglesValues(2, 3, 4);
            TrianglesValues t3 = new TrianglesValues(4, 5, 6);


            List<TrianglesValues> triangleValues = new List<TrianglesValues>();
            triangleValues.Add(t1);
            triangleValues.Add(t2);
            triangleValues.Add(t3);

            Triangle triangle;
            foreach (var value in triangleValues)
            {
                triangle = new Triangle(value.s1,value.s2,value.s3);
                bool result = triangle.TestForNULL(value.s1, value.s2, value.s3);
                Assert.IsTrue(result, "Expected the correct value of the sides or not NULL values; Actual : {0}", value, result);
            }

        }
    }

    public class TrianglesValues
    {
        public double s1;
        public double s2;
        public double s3;
        string values;

        public TrianglesValues(double _s1,double _s2, double _s3)
        {
            s1 = _s1;
            s2 = _s2;
            s3 = _s3;
        }

       
    }
}
