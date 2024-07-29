using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDs
{
    /* Lisvok Substitution Principle - LSP
     * Object of parent class should be replaceable with object of a child class without any modification.
     * 
     */

    // Violates LSP
    // Method Overriding
    class  Bank
    {
        public virtual void Credit(decimal amount)
        {
            Console.WriteLine("Default");
        }

        public virtual void Debit(decimal amount)
        {
            Console.WriteLine("Default");
        }
    }

    class SavingAccount: Bank
    {
        public override void Credit(decimal amount)
        {
            Console.WriteLine($"Rs. {amount} credited");
        }

        public override void Debit(decimal amount)
        {
            Console.WriteLine($"Rs. {amount} debited");
        }
    }

    // Abstraction
    abstract class BankAccount
    {
        public  abstract void Credit(decimal amount);

        public abstract void Debit(decimal amount);
        
    }

    class RetailUser : BankAccount
    {
        public override void Credit(decimal amount)
        {
            Console.WriteLine($"Rs. {amount} credited");
        }

        public override void Debit(decimal amount)
        {
            Console.WriteLine($"Rs. {amount} debited");
        }
    }

}
