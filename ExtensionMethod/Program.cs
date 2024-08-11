using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            JObject obj = new JObject();

            string str = "";
            str.SerializeObjects(obj);
        }
    }

    public static class JSONExtension
    {

        public static string SerializeObjects(this String str, object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }

    public class BaseClass
    {
        protected void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        private protected void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        protected internal void M3()
        {
            Console.WriteLine("Method Name: M3");
        }
    }

    static class NewMethodClass
    {

        // Method 4
        public static void M4(this BaseClass g)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5
        public static void M5(this Geek g, string str)
        {
            Console.WriteLine(str);
        }
    }

    interface InterfaceA
    {
        void M1();
    }

    interface InterfaceB: InterfaceA
    {
        void M2();
    }
    class ImplementClass : InterfaceB
    {
        public void M1()
        {
            throw new NotImplementedException();
        }

        public void M2()
        {
            throw new NotImplementedException();
        }
    }
}
