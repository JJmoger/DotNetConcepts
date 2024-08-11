namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new UserManagement("sanjay", "welcome@123");
            user.Display();
        }
    }

    public partial class UserManagement
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public partial class UserManagement
    {
        public UserManagement(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Password);
        }
    }
}
