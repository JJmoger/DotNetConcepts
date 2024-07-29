namespace MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the object of the derived class 
            MyFamily obj = new MyMember();

            // Access the method of derived class 
            obj.Member();
        }
    }

    // Base Class 
    public class MyFamily
    {

        public void Member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class 
    public class MyMember : MyFamily
    {

        public new void Member()
        {
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                   "Age: 39 \nName: Rohan, Age: 20 ");
        }
    }
}
