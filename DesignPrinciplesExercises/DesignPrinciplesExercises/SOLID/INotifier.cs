namespace SOLIDPrinciple
{
    public interface INotifier
    {
        void Send(string recipient, string message);
    }
}
