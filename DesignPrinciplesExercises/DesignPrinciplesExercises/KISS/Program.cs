using System;

namespace KISSPrinciple
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("Ejecutando KISS...");

            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            decimal[] prices = Console.ReadLine()
                .Split(',')
                .Select(decimal.Parse)
                .ToArray();

            Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
            decimal tip = Console.ReadLine().ToLower() == "s" ?
                decimal.Parse(Console.ReadLine()) : 10;

            RestaurantBill bill = new RestaurantBill();
            Console.WriteLine($"Total a pagar: {bill.CalculateTotal(prices, tip):0.00}");
        }
    }
}
