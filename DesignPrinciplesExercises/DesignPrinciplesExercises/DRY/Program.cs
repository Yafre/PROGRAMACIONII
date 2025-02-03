using System;

namespace DRYPrinciple
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("Ejecutando DRY...");

            Payroll payroll = new Payroll();
            Console.Write("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
            int type = int.Parse(Console.ReadLine());

            decimal salary;
            if (type == 1)
            {
                Console.Write("Ingrese el salario base: ");
                salary = decimal.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Ingrese el sueldo por hora: ");
                decimal hourlyRate = decimal.Parse(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas: ");
                int hoursWorked = int.Parse(Console.ReadLine());
                salary = hourlyRate * hoursWorked;
            }

            Console.WriteLine($"Salario neto: {payroll.CalculateSalary(salary):0.00}");
        }
    }
}
