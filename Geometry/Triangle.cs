using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using System.Linq;


namespace Geometry
{
    public class Triangle : IFigure
    {
        private const double eps = 1e-8;
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public bool IsRightTriangle { get; }
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= eps || side2 <= eps || side3 <= eps)
                throw new ArgumentException("Неверно указана сторона.");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            var maxSide = Max(Max(Side1, Side2), Side3);
            var p = (Side1 + Side2 + Side3);
            if ((p - maxSide) - maxSide < eps)
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы двух других сторон");

            IsRightTriangle = GetIsRightTriangle();
        }

        public double GetSquare()
        {
            var p = (Side1 + Side2 + Side3) / 2;
            return Round(Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3)), 2);
        }

        private bool GetIsRightTriangle()
        {
            var maxSide = Max(Max(Side1, Side2), Side3);
            return Pow(Side1, 2) + Pow(Side2, 2) + Pow(Side3, 2) - 2 * Pow(maxSide, 2) < eps;
        }
    }
}
