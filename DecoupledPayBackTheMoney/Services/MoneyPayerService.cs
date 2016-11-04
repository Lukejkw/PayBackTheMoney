using DecoupledPayBackTheMoney.Contracts;
using System;

namespace DecoupledPayBackTheMoney.Services
{
    public class MoneyPayerService : IMoneyPayerService
    {
        public void Pay(decimal amount)
        {
            // Pay back the money
            Console.WriteLine($"Paid: {amount}");
        }
    }
}