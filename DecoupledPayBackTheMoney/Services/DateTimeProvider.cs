using DecoupledPayBackTheMoney.Contracts;
using System;

namespace DecoupledPayBackTheMoney.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}