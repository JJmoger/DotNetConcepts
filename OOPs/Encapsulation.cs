using internalNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    /*Encapsulation is a practic of bundling properties and methods of a class into signle unit. 
     * Restricting the access to some of the object's component and misuse of the object's internal state. 
     * Encapsulation is achivied by using access modifiers 
     * Public, Private Protected, Internal
     * 
     * 
     */

    internal class Encapsulation
    {
        public void EncapsulationExampleExecutor()
        {
            Person person = new Person();

            Console.WriteLine($"Name {person.Name}.");
            person.SetName("Sanjay");
            Console.WriteLine($"Name {person.Name}.");

            BankAccount bankAccount = new BankAccount("sbi123", 100.99m);
        }
    }

    public class BankAccount
    {
        // By default private
        string accountNumber;
        decimal balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        void Credit()
        {

        }

        void Debit()
        {

        }


    }
}

namespace internalNamespace
{ 
    internal class Person
    {
        private string name;
        public string Name { get { return name; } protected set { name = value; } }

        public void SetName(string name)
        {
            Name = name;
        }
           
    }
}
