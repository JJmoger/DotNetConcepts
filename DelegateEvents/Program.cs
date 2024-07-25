/*  DELEGATE
 *  Delegates are Callbacks which helps to communicate between asyn and parallel execution.
 */

/*  EVENTS
 *  Event use delegate internally.So, Event is an encapsulated delagate. 
 */
namespace DelegateEvents
{
    public class Program
    {
        // Delegete Syntax
        public delegate void DelegateCallbackMethod(string name);
        public static DelegateCallbackMethod callbackMethod = null;


        /* Eaxmple 2 */
        public delegate void AysncDownloadDelegate(string url);

        //public static void DownloadAsync(string url)
        //{
        //    using HttpClient client = new HttpClient();
        //    string content =  client.GetStringAsync(url).Result;
        //    Console.WriteLine($"Downloaded content: {content}");
        //}

        //static async Task Main(string[] args) 
        //{
        //    AysncDownloadDelegate downloadDelegate = DownloadAsync;
        //    string url = "https://example.com/file.txt";
        //    downloadDelegate(url);
        //    Console.WriteLine("Download completed.");

        //}
        static void Main(string[] args)
        {
            FileService fileService = new FileService();
            fileService.SendFileDetails = Receiver;
            fileService.SendFileDetails = Receiver2;

            Task.Run(() =>
            {
                fileService.Search("D:\\Personnel");
            });

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        static void Receiver(string fileName)
        {
            Console.WriteLine($"Receiver 1 {fileName}");
        }

        static void Receiver2(string fileName)
        {
            Console.WriteLine($"Receiver 2 {fileName}");
        }

        
    }

    public class FileService
    {
        /* Eaxmple 1 */
        public delegate void SearchMethod(string search);
        public SearchMethod SendFileDetails = null;

        public void Search(string directory)
        {
            foreach (string dir in Directory.GetDirectories(directory))
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    SendFileDetails(file);
                }
            }
        }
    }

    public class DownloadService
    {
        /* Eaxmple 1 */
        public delegate void SearchMethod(string search);
        public SearchMethod SendFileDetails = null;

        public void Search(string directory)
        {
            foreach (string dir in Directory.GetDirectories(directory))
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    SendFileDetails(file);
                }
            }
        }
    }


}
