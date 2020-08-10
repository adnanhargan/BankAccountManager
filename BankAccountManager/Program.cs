using System;

namespace BankAccountManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount("Adnan", 10000);
            Console.WriteLine($"{account1.Number} was created for {account1.Owner} with {account1.Balance} initial balance ");

            Console.WriteLine(account1.GetAccountHistory());

        }
    }
}
