using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StaticSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "jj100klom300lklk99"
            var str = UtilityHelper.Serializer(new Dictionary<string, string> { { "key", "value" } });
            var obj = UtilityHelper.Deserializer(str);

        }
    }
    interface IUtilityHelper
    {
        string Serializer(object data);
        object Deserializer(string value);

    }

    static class UtilityHelper
    //static class can't implement interfaces 
    //: IUtilityHelper
    {
        //public UtilityHelper()
        //{
        //static class can't have constructor 
        //}
        //static class can't have variable
        //private string SomeVariable;
        public static string Serializer(object data)
        {
            string strValue = string.Empty;
            try
            {
                strValue = JsonConvert.SerializeObject(data);
            }
            catch (Exception)
            {
                return default;
            }
            return strValue;
        }

        public static object Deserializer(string value)
        {
            try
            {
                 return JsonConvert.DeserializeObject(value);
            }
            catch (Exception)
            {
                return default;
            }
        }

        public static bool IsValidEmail(this string email)
        {
            // Simple email validation logic
            return email.Contains("@") && email.Contains(".");
        }
    }
}
