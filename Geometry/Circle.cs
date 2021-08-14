using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Geometry
{
    public class Circle : IFigure
    {
        public double  Radius { get; set; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверно указан радиус круга.");
            Radius = radius;
        }
        public double GetSquare()
        {
            return PI * Pow(Radius, 2);
        }

    }
}
