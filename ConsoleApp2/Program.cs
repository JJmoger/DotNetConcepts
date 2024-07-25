/*  DELEGATE
 *  Delegates are Callbacks which helps to communicate between asyn and parallel execution.
 *  Multicast delegate - Multiple function attched to a delegate.
 */

/*  EVENTS
 *  Event use delegate internally.So, Event encapsulate delagate and make them safe. 
 *  Delegate are callback and not encapsulated so not safe.
 *  Event work on publisher subscriber model, are encapsulate so safe.
 */
using System.Text.Json.Serialization;

namespace DelegateEvents
{
    public class Program
    {
        // Delegete Syntax
        public delegate void DelegateCallbackMethod(string name);
        public static DelegateCallbackMethod callbackMethod = null;


        /* Eaxmple 2 */
        //public delegate Task AysncDownloadDelegate(string url);

        //public static async Task DownloadAsync(string url)
        //{
        //    using HttpClient client = new HttpClient();
        //    string content = await client.GetStringAsync(url);

        //    var file = File.WriteAllTextAsync(Directory.GetCurrentDirectory()+"/download.html", content);
        //    Console.WriteLine($"Downloaded content: {content}");
        //}

        static async Task DownloadFileAsync(string content)
        {
            Console.WriteLine($"Downloaded content: {content}");
        }

        static async Task Main(string[] args)
        {
            //AysncDownloadDelegate downloadDelegate = DownloadAsync;
            string url = "https://example.com/";
            //await downloadDelegate(url);

            DownloadService downloadService = new DownloadService();
            downloadService.downloadCallback = DownloadFileAsync; // receive

            await downloadService.DownloadAsync(url); // delegate trigger method//  send


            Console.WriteLine("Download completed.");

        }
            //static void Main(string[] args)
            //{
            //    FileService fileService = new FileService();
            //    fileService.SendFileDetails = Receiver;
            //    fileService.SendFileDetails = Receiver2;

            //    Task.Run(() =>
            //    {
            //        fileService.Search("D:\\Personnel");
            //    });

            //    Console.WriteLine("Press any key");
            //    Console.ReadLine();
            //}

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
        /* Eaxmple 3 */
        public delegate Task AsyncDownloadDelegate(string url);
        public AsyncDownloadDelegate downloadCallback = null;

        public async Task DownloadAsync(string url)
        {
            using HttpClient client = new HttpClient();
            string content = await client.GetStringAsync(url);
            var file = File.WriteAllTextAsync(Directory.GetCurrentDirectory() + "/download.html", content);
            await downloadCallback(content);

        }
    }
}
