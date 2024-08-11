using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class FactoryPattern
    {
    }

    public abstract class Document
    { 
        public abstract void Print();
    }

    public class PdfDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing PDF Document...");
        }
    }

    public class WordDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing Word Document...");
        }
    }

    public abstract class DocumentCreator
    {
        public abstract Document CreateDocument();
    }

    public class PdfDocumentCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new PdfDocument();
        }
    }

    public class WordDocumentCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }

    public class Client
    {
        private readonly Document _document;

        public Client(DocumentCreator creator)
        {
            _document = creator.CreateDocument();
        }

        public void PrintDocument()
        {
            _document.Print();
        }
    }

}
