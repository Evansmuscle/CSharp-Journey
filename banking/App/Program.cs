using Customers;
using Library;
using Enums;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Boolean bankingInProgress = true;

            Console.WriteLine("Welcome to Kaan Bank!");

            while (!bank.IsLoggedIn())
            {
                Console.WriteLine("Would you like to login or register?");
                Console.WriteLine("Input 1 to login, and 2 to register:");

                string? input = Console.ReadLine();

                if (input is null || (input != "1" && input != "2"))
                {
                    Console.WriteLine("Please input a valid number, 1 or 2");
                    continue;
                }
                Console.WriteLine("Please enter your username:");
                string? userName = Console.ReadLine();

                if (userName is null)
                {
                    Console.WriteLine("Please enter a valid username!");
                    continue;
                }

                Console.WriteLine("Please enter your password:");
                string? password = Console.ReadLine();

                if (password is null)
                {
                    Console.WriteLine("Please enter a valid password!");
                    continue;
                }

                if (input == "1")
                {
                    bank.Login(userName, password);
                }

                if (input == "2")
                {
                    bank.Register(userName, password);
                }
            }

            while (bankingInProgress)
            {
                Console.WriteLine("Please input 1 to withdraw money.");
                Console.WriteLine("2 to deposit money.");
                Console.WriteLine("And 3 to quit banking.");

                string? input = Console.ReadLine();

                if (input is null || (input != "1" && input != "2" && input != "3"))
                {
                    Console.WriteLine("Please enter a valid input!");
                    continue;
                }

                if (input == "3")
                {
                    Console.WriteLine("Have a nice day!");
                    bankingInProgress = false;
                    continue;
                }

                Console.WriteLine("Please enter your password:");
                string? passwordInput = Console.ReadLine();

                if (passwordInput is null)
                {
                    Console.WriteLine("Please enter a valid password.");
                    continue;
                }

                if (!bank.IsCorrectPassword(passwordInput))
                {
                    Console.WriteLine("Wrong password! Please try again.");
                    continue;
                }


                Console.WriteLine("Please enter the amount for the transfer");
                Console.WriteLine("Enter any decimal points like 3.14, do not use a comma!");

                decimal amount;

                string? amountInput = Console.ReadLine();

                if (amountInput is null)
                {
                    Console.WriteLine("Please enter a valid amount!");
                    continue;
                }

                bool isNumeric = decimal.TryParse(amountInput, out amount);

                if (!isNumeric)
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

                if (input == "1")
                {
                    bank.Transfer(amount, passwordInput, TransferTypes.Withdraw);
                }

                if (input == "2")
                {
                    bank.Transfer(amount, passwordInput, TransferTypes.Deposit);
                }
            }
        }
    }
}