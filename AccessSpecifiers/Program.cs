using ExtensionMethod;
using Newtonsoft.Json.Linq;
using PublicAccessClass;
using System.Numerics;

namespace AccessSpecifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Public Access
            CommonService commonService = new CommonService();
            commonService.ServiceName = "Test";
            commonService.Action();

            //Protected Access
            ProtectedService protectedService = new ProtectedService();
            ProtectedDerived protectedDerived = new ProtectedDerived();
            protectedDerived.Start();

            //Internal Access
            InternalService internalService = new InternalService();
            internalService.ServiceName = "Test";
            internalService.Start();
            // Cant access from different assembly
            string str = "Hello world";
            JObject obj = new JObject();
            str.SerializeObjects(obj);

            BaseClass baseclass = new BaseClass();
            

            // Private Access
            PrivateService privateService = new PrivateService();

            //Protected Internal
            ProtectedInternalService protectedInternalService = new ProtectedInternalService(); 
            protectedInternalService.ServiceName = "Test";
            protectedInternalService.Start();

            //Private Protected
            PrivateProtectedService privateProtectedService = new PrivateProtectedService();
            privateProtectedService.M1();

        }
    }
}

namespace PublicAccessClass
{
    public class CommonService
    {
        public string ServiceName { get; set; }
        public void Action()
        {
            Console.WriteLine("Service running");
        }
    }

    public class ProtectedService
    {
        protected string ServiceName { get; set; }
        protected void Action()
        {
            Console.WriteLine("Service running");
        }
    }

    public class ProtectedDerived: ProtectedService
    {
        public void Start()
        {
            Action();
            ServiceName = "Test";
            Console.WriteLine(ServiceName);
        }
    }

    internal class InternalService 
    {
        internal string ServiceName { get; set; }
        internal void Run()
        {
            Console.WriteLine("Service running");
        }
    }
    internal class PrivateService
    {
        private string ServiceName { get; set; }
        private void Start()
        {
            
            Console.WriteLine("Service running");
        }
    }

    internal class ProtectedInternalService: BaseClass
    {
        protected internal string ServiceName { get; set; }
        protected internal void Start()
        {
            M1();
            M3();
            Console.WriteLine("Service running");
        }
    }

    internal class PrivateProtectedService: BaseClass
    {
        private protected string ServiceName { get; set; }
        private protected void Start()
        {
            //M2();
            Console.WriteLine("Service running");
        }
    }
}
