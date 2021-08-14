using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;

namespace GeometryTest
{
    [TestClass]
    public class CircleTest
    {
        const double eps = 1e-8;

        [TestMethod]
        public void ZeroRadius()
        {
            var radius = 0;
            try
            {
                var c = new Circle(radius);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }             
        }

        [TestMethod]
        public void NegativeRadius()
        {
            var radius = -3;
            try
            {
                var c = new Circle(radius);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }
        }

        [TestMethod]
        public void GetSquare()
        {
            var radius = 5;
            var c = new Circle(radius);

            var expected = Math.PI * Math.Pow(radius, 2);
            var sq = c.GetSquare();

            Assert.IsTrue(Math.Abs(sq - expected) < eps);
        }
    }
}
