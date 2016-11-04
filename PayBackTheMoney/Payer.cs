using PayBackTheMoney.Services;
using System;

namespace PayBackTheMoney
{
    public class Payer
    {
        public bool TryPayMoney(DateTime timeToPayBackTheMoney, bool canDelayProcess)
        {
            if (!canDelayProcess && DateTime.Now >= timeToPayBackTheMoney)
            {
                // Damn, have to pay
                var payer = new MoneyPayerService();
                payer.Pay(7000000M);

                // Send Thuli email
                var notifications = new NotificationService();
                notifications.Send("jacob@anc.gov.za", "tuli@madonsela.gov.za", "I pay bak moneyies.\r\n Love, Jacob");
                return true;
            }

            // "HA HA HA! "Inkandla"" HA HA HA
            return false;
        }
    }
}