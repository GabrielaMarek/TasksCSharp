using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount { AccountNumber = 1, Balance = 10345 };
            CheckingAccount checkingAccount = new CheckingAccount { AccountNumber = 2, Balance = 53420 };

            savingsAccount.Deposit(2000);
            savingsAccount.Withdraw(1593);
            savingsAccount.CalculateInterest();

            checkingAccount.Deposit(1780);
            checkingAccount.Withdraw(370);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
