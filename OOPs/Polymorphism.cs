using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.PolymorphismType
{
    internal class Polymorphism
    {
        /* Polymorphism allows objects of different classes to be treated as objects of a common superclass.
         * And It enables a single method to behave differently depending on the object it is acting upon. 
         * Polymorphish can be implemented by using Method Overloading and Method Overriding 
         * 
         * Polymorphism has two types
         * Complie-time Polymorphism (Static polymorphism) - Method Overloading, Operator Overloading
         * Runtime-time Polymorphism (Dynamic polymorphism) - Method Overriding
         * 
         * Method Overloading allows multiple methods in same class to have same name but different parameters.
         * Operator Overloaing allows operator to be overloaded to define custom behaviour of thr opertor.
         * Method Overriding allows to override parent class method implementation in child class.
         */

        public void OverridePolymorphismExample()
        {
            ATM atm = new ATM();
            ATM atmIndia = new AtmIndia();
            ATM atmUSA = new AtmUSA();

            atm.CashWithdraw();
            atmIndia.CashWithdraw();
            atmUSA.CashWithdraw();
        }

        public void OverloadPolymorphismExample()
        {
            var calc = new Calculator();
            calc.Add(15, 25);
            calc.Add(2, 8, "KG");
        }

        public void OperatorPolymorphismExample()
        {
            Complex c1 = new Complex(3, 2);
            Complex c2 = new Complex(1, 7);

            Complex sum = c1 + c2;

            Console.WriteLine(sum);
        }

    }


    //------------------- METHOD OVERRIDING ------------------------------
    public class ATM
    {
        public virtual void CashWithdraw()
        {
            Console.WriteLine("Cash withdraw");
        }

        public virtual void BalanceInquiry()
        {
            Console.WriteLine("Show Balance");
        }
    }

    class AtmIndia : ATM
    {
        public override void CashWithdraw()
        {
            Console.WriteLine("Cash withdraw in Rupees");
        }
    }

    class AtmUSA : ATM
    {
        public override void CashWithdraw()
        {
            Console.WriteLine("Cash withdraw in Dollar");
        }

        public static new void BalanceInquiry()
        {
            Console.WriteLine("Balance 99.00 Dollar");
        }
    }
    // --------------------- END ---------------------------------------
    //-----------------METHOD OVERLOADING --------------------------------
    class Calculator
    {
        public void Add(int value1, int value2)
        {
            Console.WriteLine(value1 + value2);
        }

        public void Add(int value1, int value2, string unit)
        {
            Console.WriteLine(value1 + value2 + unit);
        }
    }

    // --------------------- END ---------------------------------------
    //----------------- OPERATOR OVERLOADING --------------------------------
    class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

    } // --------------------- END ---------------------------------------
}
