/* OOP - Object oriented programming - real world object
 * 
 */


using OOPs.PolymorphismType;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee();
            emp1.Name = "Sanjay";
            emp1.Address = "BLR";

            var manager = new Manager();
            manager.Management();

            Abstraction abstraction = new Abstraction();
            abstraction.AbstractionExample();
            abstraction.AbstractionExample2();

            Polymorphism polymorphism = new Polymorphism();
            polymorphism.OverridePolymorphismExample();
            polymorphism.OverloadPolymorphismExample();
            polymorphism.OperatorPolymorphismExample();

            Inheritance inheritance = new Inheritance();
            inheritance.InheritanceExampleExecutor();

            Encapsulation encapsulation = new Encapsulation();
            encapsulation.EncapsulationExampleExecutor();

        }
    }

    /* Class is type, blueprint of real world object. Object is the instance class.
     * 
     */
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual int Retirement() {
            return 60;
        }
    }

    public class Manager : Employee
    {
        public void Management()
        {
            Console.WriteLine("Manage project");
        }

        public override int Retirement() {
            return 55;
        }
    }

    /* A - Abtraction - show only whats neccessary. design phase
     * P - Polymorphism - ability of object to acts differently in different condition.
     * I - Inheritance - child class inherits state and behaviours of parent. 
     * E - Encapsulation - bind data in single unit, Hide complexity, developement phase, getter setter property
     */

    /* virtual keyword help to define some method in the parent class which can be overridden in the child class.
     * Method overloading mean same method names with different signature in the 
     * Operator Overloading 
     */
}
