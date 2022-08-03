using Customers;
using Library;
using Enums;

namespace App
{
    public class Bank
    {
        private Account? currentAccount = null;

        public Boolean IsCorrectPassword(string password)
        {
            if (this.currentAccount is not null)
            {
                return this.currentAccount.CheckPassword(password);
            }

            return false;
        }

        public Boolean IsLoggedIn()
        {
            if (this.currentAccount is null)
            {
                return false;
            }

            return true;
        }

        public void Register(string name, string password)
        {
            Account newAccount = new Account(0, name, password);

            JsonUtils.ConvertToJsonAndWrite(newAccount, $"{name}");

            this.currentAccount = newAccount;
        }

        public void Login(string name, string password)
        {
            Account? account = JsonUtils.ReadFromJson<Account>($"./data/{name}.json");

            Console.WriteLine($"Your balance is {account.Balance}");
            Console.WriteLine($"Your name is is {account.Name}");

            if (account is null)
            {
                Console.WriteLine("There is no such user, you might consider registering.");
                Console.WriteLine("To register, input 1, if not, input anything and you'll try to login again.");

                string? answer = Console.ReadLine();

                if (answer is not null && answer is "1")
                {
                    this.Register(name, password);
                    return;
                }

                return;
            }

            if (account.CheckPassword(password))
            {
                Console.WriteLine("You logged in successfully!");
                this.currentAccount = account;
            }
        }

        public void Transfer(decimal amount, string password, TransferTypes type)
        {
            if (this.currentAccount is null)
            {
                Console.WriteLine("You're not logged in!");
                return;
            }

            switch (type)
            {
                case TransferTypes.Withdraw:
                    this.currentAccount.WithdrawMoney(amount, password);
                    return;
                case TransferTypes.Deposit:
                    this.currentAccount.DepositMoney(amount, password);
                    return;
            }
        }
    }
}