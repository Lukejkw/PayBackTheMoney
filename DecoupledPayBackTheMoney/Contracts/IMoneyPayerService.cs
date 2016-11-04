namespace DecoupledPayBackTheMoney.Contracts
{
    public interface IMoneyPayerService
    {
        void Pay(decimal amount);
    }
}