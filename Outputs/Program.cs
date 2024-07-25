using System.Runtime.CompilerServices;

namespace Outputs
{
    internal class Program
    {
        public static String str;
        public static string str2;
        public static int i;
        public static float f;
        public static double d;
        public static bool boolean;
        public static DateTime dateTime;

        public static void Main(string[] args)
        {
            Console.WriteLine($"String class {str}.");
            Console.WriteLine($"string datatype {str2}");
            Console.WriteLine($"int datatype {i}");
            Console.WriteLine($"float datatype {f}");
            Console.WriteLine($"double datatype {d}");
            Console.WriteLine($"bool datatype {boolean}");
            Console.WriteLine($"Datetime {dateTime.ToString()}");

            Console.WriteLine("Method1 start 1");
            Method1();
            Console.WriteLine("Method1 end 1");
            Console.ReadLine();
            var obj = new Program();
            obj.Clone();
        }


        public static async void Method1()
        {
            Console.WriteLine("Method1 start");
            // Task.Run(() => { });
            await Task.Delay(4000);
            Console.WriteLine("Method1 end");

        }
        public void Clone() {
            this.Clone();
        }
    }
}
