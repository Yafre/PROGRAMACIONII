using System;

namespace Shapes_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5, 10),
                new Triangle(4, 8),
                new Circle(7)
            };

            double[] areas = new double[shapes.Length];

            Console.WriteLine("Cálculo de Áreas de Formas:");
            Console.WriteLine("==========================");

            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
                Console.WriteLine($"Forma {i + 1}: {shapes[i].GetType().Name}, Área: {areas[i]:F2}");
            }
        }
    }
}
