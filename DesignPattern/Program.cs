namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = Singleton.Instance;
            var countries = instance.GetCountries();

            countries = instance.GetCountries();

            DocumentCreator pdfCreator = new PdfDocumentCreator();
            Client pdfClient = new Client(pdfCreator);
            pdfClient.PrintDocument();  // Output: Printing PDF Document...

            DocumentCreator wordCreator = new WordDocumentCreator();
            Client wordClient = new Client(wordCreator);
            wordClient.PrintDocument();  // Output:
        }
    }
}
