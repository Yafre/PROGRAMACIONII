namespace SOLIDPrinciple
{
    public class EmailNotifier : INotifier
    {
        public void Send(string email, string message)
        {
            Console.WriteLine($"Enviando Email a {email}: {message}");
        }
    }
}
