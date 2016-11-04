using DecoupledPayBackTheMoney.Contracts;
using System;

namespace DecoupledPayBackTheMoney.Services
{
    internal class NotificationService : INotificationService
    {
        public void Send(string fromEmail, string toEmail, string message)
        {
            Console.WriteLine($"Message sent from {fromEmail} to {toEmail}");
            Console.WriteLine($"Message:{message}");
        }
    }
}