using System;

namespace PayBackTheMoney.Services
{
    internal class NotificationService
    {
        public void Send(string fromEmail, string toEmail, string message)
        {
            Console.WriteLine($"Message sent from {fromEmail} to {toEmail}");
            Console.WriteLine($"Message:{message}");
        }
    }
}