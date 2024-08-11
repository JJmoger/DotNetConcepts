using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

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
            //Reverse string extension method
            var str = "Sanjay Kumar is a developer";
            Console.WriteLine(str.MyReverseSentence());

            int[] numbers = { 11, 2, 15, 7 };
            int target = 9;

            int[] result = FindTwoSum(numbers, target);

            if (result != null)
            {
                Console.WriteLine($"Indices of the two numbers are: {result[0]} and {result[1]}");
            }
            else
            {
                Console.WriteLine("No two numbers sum up to the target value.");
            }

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

        public static int[] FindTwoSum(int[] nums, int target)
        {
            // Create a dictionary to store the complement and its index
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numDict.TryGetValue(complement, out int index))
                {
                    // If complement is found in the dictionary, return the indices
                    return new int[] { index, i };
                }

                // Store the index of the current number in the dictionary
                numDict[nums[i]] = i;
            }

            // Return null if no such pair is found
            return null;
        }

       
    }

    internal static class StringExtension
    {
        public static string MyReverse(this string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < str.Length - 1; i++, j--)
            {
                ch[i] = str[j];
                ch[j] = str[i];
            }
            return new string(ch);
        }

        public static string MyReverseSentence(this string str)
        {
            var stringBuilder = new StringBuilder();
            int startIndex = 0;

            var splitStr = str.Split();
            Console.WriteLine(str.Length);
            for (int i = 0; i < splitStr.Length; i++)
            {
                //if (str[i] == ' ')
                //{
                //    string revStr = str.Substring(startIndex, i);
                //    stringBuilder.Append(revStr.MyReverse());
                //    startIndex = i+1;
                //    stringBuilder.Append(' ');
                //}
                //else if (i == str.Length-1)
                //{
                //    string revStr = str.Substring(startIndex);
                //    stringBuilder.Append(revStr.MyReverse());
                //}

                stringBuilder.Append(splitStr[i].MyReverse());
                if(i < splitStr.Length-1 )
                stringBuilder.Append(' ');

            }
            Console.WriteLine(stringBuilder.ToString().Length);
            return stringBuilder.ToString();
        }
    }
}
