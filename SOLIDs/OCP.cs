using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDs
{
    /* Open/Close princilple - OCP
     * A class sholud be open for extension but close for modification.
     * 
     */

    // Voilate OCP
    class Report
    {
        public string Format { get; set; }

        public void GenerateReport()
        {
            if (Format == "PDF")
            {
                Console.WriteLine("PDF report");
            }
            else if (Format =="Word")
            {
                Console.WriteLine("Word Format");
            }
        }
    }

    interface IReport
    {
        void GenerateReport();
    }

    class PDFReports: IReport
    {
        public void GenerateReport() 
        {
            Console.WriteLine("PDF report");
        }
    }

    class WordReports : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Word report");
        }
    }

    class ReportExtension
    {
        private IReport report;

        public ReportExtension(IReport report)
        {
            this.report = report;
        }

        public void GenerateReport() 
        {
            report.GenerateReport();
        }
    }
}
