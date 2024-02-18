using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_and_interfaces
{
    public abstract class Account
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance is: {Balance:C}");
        }
        public abstract void Withdraw(decimal amount);
    }
}
