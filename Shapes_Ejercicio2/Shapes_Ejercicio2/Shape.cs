using System;

namespace Shapes_Ejercicio2
{
    public abstract class Shape
    {
        protected double Width { get; set; }
        protected double Height { get; set; }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateSurface();
    }
}
