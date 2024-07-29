using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    /* Inheritance allows a class to inherit properties and methods from another class. Class inheriting is called as child class
     * and class from inherited is parent class.
     * 
     * Types of inheritance
     * Single Inheritance
     * Multilevel Inheritance
     * Hierarchical Inheritance
     * Hybrid Inheritance
     * 
     * Multiple Inheritance is not supported.
     */

    internal class Inheritance
    {
        public void InheritanceExampleExecutor()
        {
            Printer printer = new Printer();
            AllInOnePrinter allInOne = new AllInOnePrinter();

            printer.Print();

            allInOne.Print();
            allInOne.Scan();
            allInOne.Copy();
        }
    }

    class Printer
    {
        public void Print()
        {
            Console.WriteLine($"Printing");
        }
    }

    class ColorPrinter: Printer
    {
        void ColorPrint()
        {
            Console.WriteLine("Color printing");
        }
    }

    class AllInOnePrinter : Printer
    {
        public void Scan()
        {
            Console.WriteLine("Scanning documents");
        }

        public void Copy()
        {
            Console.WriteLine("Copy documents");
        }
    }

}
