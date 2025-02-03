using System;

namespace YAGNIPrinciple
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("Ejecutando YAGNI...");

            ProductService service = new ProductService();
            Console.Write("Seleccione una opción (1: Agregar producto, 2: Eliminar producto): ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Ingrese el nombre del producto: ");
                string name = Console.ReadLine();
                Console.Write("Ingrese el precio: ");
                decimal price = decimal.Parse(Console.ReadLine());
                service.AddProduct(name, price);
            }
            else
            {
                Console.Write("Ingrese el ID del producto a eliminar: ");
                int id = int.Parse(Console.ReadLine());
                service.DeleteProduct(id);
            }
        }
    }
}
