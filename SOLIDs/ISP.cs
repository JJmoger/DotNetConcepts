using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDs
{
    internal class ISP
    {
        /* Interface Segregation Principle - ISP
         * A class should not be forced to depend on interfaces they do not use.
         * It can be implemented using Multiple inheritance. 
         * 
         */

        //Violates ISP
        interface IWorker
        {
            void Work();
            void Eat();
            void Run()
            {

            }
        }

        class Human : IWorker
        {
            public void Eat()
            {
                Console.WriteLine("Human eat");
            }

            public void Work()
            {
                Console.WriteLine("work");
            }
        }

        class Robot : IWorker
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                Console.WriteLine("work");
            }
        }

        interface IWorkForce
        {
            void Workable();
        }

        interface IFeedable
        {
            void Feed();
        }

        class Man : IWorkForce, IFeedable
        {
            public void Feed()
            {
                Console.WriteLine("eat");
            }

            public void Workable()
            {
                Console.WriteLine("work");
            }
        }

        class Machine: IWorkForce
        {
            public void Workable()
            {
                Console.WriteLine("work");
            }
        }
    }
}
