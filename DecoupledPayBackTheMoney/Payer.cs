using DecoupledPayBackTheMoney.Contracts;
using DecoupledPayBackTheMoney.Services;
using System;

namespace DecoupledPayBackTheMoney
{
    public class Payer
    {
        private readonly IMoneyPayerService _payer;
        private readonly INotificationService _notificationService;
        private readonly IDateTimeProvider _dateTimeProvider;

        /// <summary>
        /// The pattern of injecting your dependecies via the constructor like this is called the "strategy pattern"
        /// </summary>
        /// <param name="payer"></param>
        /// <param name="notificationService"></param>
        /// <param name="dateTimeProvider"></param>
        public Payer(
            IMoneyPayerService payer,
            INotificationService notificationService,
            IDateTimeProvider dateTimeProvider)
        {
            _payer = payer;
            _notificationService = notificationService;
            _dateTimeProvider = dateTimeProvider;
        }

        /// <summary>
        /// Lazy-man's Dependency Injection
        ///
        /// This is our public parameterless contructor. It takes care of passing in our concrete implementations.
        ///
        /// Ideally you would be using IoC framework for this like Ninject or AutoFac
        /// </summary>
        public Payer()
            : this(new MoneyPayerService(),
                  new NotificationService(),
                  new DateTimeProvider())
        {
        }

        public bool TryPayMoney(DateTime timeToPayBackTheMoney, bool canDelayProcess)
        {
            DateTime now = _dateTimeProvider.GetCurrentDateTime();
            if (!canDelayProcess && timeToPayBackTheMoney <= now)
            {
                // Damn, have to pay
                _payer.Pay(7000000M);

                // Send Thuli email
                _notificationService.Send("jacob@anc.gov.za", "tuli@madonsela.gov.za", "I pay bak moneyies.\r\n Love, Jacob");
                return true;
            }

            // "HA HA HA! "Inkandla"" HA HA HA
            return false;
        }
    }
}