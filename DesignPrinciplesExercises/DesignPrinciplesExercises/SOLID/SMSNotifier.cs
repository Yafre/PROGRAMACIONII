namespace SOLIDPrinciple
{
    public class SMSNotifier : INotifier
    {
        public void Send(string phone, string message)
        {
            Console.WriteLine($"Enviando SMS a {phone}: {message}");
        }
    }
}
