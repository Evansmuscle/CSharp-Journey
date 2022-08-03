namespace Customers
{
    public interface ITransfers
    {
        void WithdrawMoney(decimal amount, string password);

        void DepositMoney(decimal amount, string password);
    }
}