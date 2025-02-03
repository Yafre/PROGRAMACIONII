using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el ejercicio a ejecutar:");
        Console.WriteLine("1. KISS");
        Console.WriteLine("2. DRY");
        Console.WriteLine("3. YAGNI");
        Console.WriteLine("4. SOLID");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                KISSPrinciple.Program.Run();
                break;
            case 2:
                DRYPrinciple.Program.Run();
                break;
            case 3:
                YAGNIPrinciple.Program.Run();
                break;
            case 4:
                SOLIDPrinciple.Program.Run();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}

