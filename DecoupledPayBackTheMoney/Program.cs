using System;

namespace DecoupledPayBackTheMoney
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var payer = new Payer();
            payer.TryPayMoney(new DateTime(2017, 01, 01), true);
        }
    }
}