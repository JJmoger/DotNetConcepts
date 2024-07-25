namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = Singleton.Instance;
            var countries = instance.GetCountries();

            countries = instance.GetCountries();
        }
    }
}
