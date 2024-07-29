using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDs
{
    /* SOLID is an acronym for the group five principles of object oriented design to develop an application.
     * 
     * Single Responsibility Principle - SRP
     * A class should have only one reason to change, meaning it should have only one job or responsibility.
     */

    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // Violating SRP
        public void SaveUser()
        {
            Console.WriteLine("User data saved.");
        }

        public void SendEmail()
        {
            Console.WriteLine("Email Send");
        }
    }

    class UserRepository
    {
        public void SaveUser(User user)
        {
            Console.WriteLine("User data saved.");
        }
    }

    class EmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("User data saved.");
        }
    }
}
