//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DesignPattern
{
    public interface ISingleton
    {

    }
    public class Singleton
    {
        private static Singleton _instance;
        

        private static readonly object lockObject = new object();
        private static List<string> countries;

        private static Lazy<Singleton> _lazyInstance = new Lazy<Singleton>(() => new Singleton());
        private static Lazy<List<string>> _lazyCountriesList = new Lazy<List<string>>(() => new List<string>());
        private Singleton()
        {
                
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
      
        public List<string> GetCountries()
        {
            if (countries == null)
            {
                lock (lockObject)
                {
                    if (countries == null) {
                        InitializeCountries();
                    }
                }
            }
            return countries;
        }
        public static void InitializeCountries() {

            countries = new List<string>
            {
                "India",
                "Nepal",
                "Bhutan"
            };
        }

        public static List<string> InitializeCountries(string lazy = "")
        {

            countries = new List<string>
            {
                "India",
                "Nepal",
                "Bhutan"
            };

            return countries;
        }
    }
}
