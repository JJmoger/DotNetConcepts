namespace SOLIDs
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            // SRP
            var user = new User();
            user.Name = "Sanjay";
            user.Email = "email@gmail.com";

            var repos = new UserRepository();
            repos.SaveUser(user);

            var emails = new EmailService();
            emails.SendEmail(user.Email);

            // OCP
            IReport pdf = new PDFReports();
            IReport word = new WordReports();
            ReportExtension report = new ReportExtension(pdf);
            report.GenerateReport();

            report = new ReportExtension(word);
            report.GenerateReport();

            // LSP
          



        }
        
    }
}
