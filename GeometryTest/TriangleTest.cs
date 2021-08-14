using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;

namespace GeometryTest
{
    [TestClass]
    public class TriangleTest
    {
        const double eps = 1e-8;

        [TestMethod]
        public void WrongSide()
        {
            try
            {
                var t = new Triangle(-3, 4, 5);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }
        }

        [TestMethod]
        public void SumOfTwoLessThenOne()
        {
            try
            {
                var t = new Triangle(3, 4, 15);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }
        }

        [TestMethod]
        public void InitTriangle()
        {
            double s1 = 3, s2 = 4, s3 = 5;

            var triangle = new Triangle(s1, s2, s3);

            
            Assert.IsNotNull(triangle);
            Assert.IsTrue(Math.Abs(triangle.Side1 - s1) < eps);
            Assert.IsTrue(Math.Abs(triangle.Side2 - s2) < eps);
            Assert.IsTrue(Math.Abs(triangle.Side3 - s3) < eps);
            Assert.IsTrue(triangle.IsRightTriangle);
        }

        [TestMethod]
        public void GetSquare()
        {
            double s1 = 3, s2 = 4, s3 = 5;
            double res = 6;
            var triangle = new Triangle(s1, s2, s3);

            var square = triangle.GetSquare();

            Assert.IsNotNull(square);
            Assert.IsTrue(Math.Abs(square - res) < eps);
        }
    }
}
