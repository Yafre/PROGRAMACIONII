using System;

namespace SOLIDPrinciple
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("Ejecutando SOLID...");

            Console.Write("Seleccione el tipo de notificación (1: Email, 2: SMS): ");
            int type = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el mensaje: ");
            string message = Console.ReadLine();

            INotifier notifier = type == 1 ? new EmailNotifier() as INotifier : new SMSNotifier();
            Logger logger = new Logger();

            Console.Write("Ingrese el destinatario (Email o Número de teléfono): ");
            string recipient = Console.ReadLine();

            notifier.Send(recipient, message);
            logger.Log(message);
        }
    }
}
