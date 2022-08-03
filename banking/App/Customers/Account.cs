using Library;

namespace Customers
{
    public class Account : ITransfers
    {
        private decimal balance;
        private string ownerName;
        private string password;

        public Account(decimal balance, string name, string password)
        {
            this.balance = balance;
            this.ownerName = name;
            this.password = password;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }

        public string Name
        {
            get
            {
                return this.ownerName;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Boolean CheckPassword(string password)
        {
            if (this.password != password)
            {
                Console.WriteLine("Wrong password!");
                return false;
            }

            return true;
        }

        public string GetBalanceMessage()
        {
            var roundedBalance = Convert.ToInt32(this.balance);
            var message = String.Format($"Hello {this.ownerName}! Your balance is: {roundedBalance.ToString()}");

            return message;
        }

        public void WithdrawMoney(decimal amount, string password)
        {
            if (this.password != password)
            {
                Console.WriteLine("Wrong password!");
                return;
            }

            if (this.balance < amount)
            {
                Console.WriteLine("Not enough money!");
                return;
            }

            this.balance -= amount;
            JsonUtils.ConvertToJsonAndWrite(this, this.ownerName);
        }

        public void DepositMoney(decimal amount, string password)
        {
            if (this.password != password)
            {
                Console.WriteLine("Wrong password!");
                return;
            }

            this.balance += amount;
            JsonUtils.ConvertToJsonAndWrite(this, this.ownerName);
        }
    }
}
