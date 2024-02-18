using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_interfaces
{
    public class SavingsAccount : Account, IInterestBearing
    {
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Not enough of founds");
            }
        }
        public void CalculateInterest()
        {
            decimal interest = Balance * 0.05m;
            Balance += interest;
            Console.WriteLine($"Interest calculated and added: {interest:C}. New balance: {Balance:C}");
        }
    }
}
