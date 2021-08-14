using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1.GetSquare());

            Triangle triangle1 = new Triangle(-3,4,5);
            Console.WriteLine(triangle1.GetSquare());
        }
    }
}
