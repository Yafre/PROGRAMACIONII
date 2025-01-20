using System;

namespace Shapes_Ejercicio2
{
    public class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius) { }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(Width, 2);
        }
    }
}
