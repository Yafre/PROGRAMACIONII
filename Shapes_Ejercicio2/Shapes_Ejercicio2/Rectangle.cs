﻿namespace Shapes_Ejercicio2
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
