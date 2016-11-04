using System;

namespace PayBackTheMoney.Services
{
    public class MoneyPayerService
    {
        public void Pay(decimal amount)
        {
            // Pay back the money
            Console.WriteLine($"Paid: {amount}");
        }
    }
}