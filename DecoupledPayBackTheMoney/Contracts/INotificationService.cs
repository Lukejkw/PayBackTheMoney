namespace DecoupledPayBackTheMoney.Contracts
{
    public interface INotificationService
    {
        void Send(string fromEmail, string toEmail, string message);
    }
}