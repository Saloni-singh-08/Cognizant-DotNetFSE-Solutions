using System;

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory wordFactory = new WordFactory();
        IDocument wordDocument = wordFactory.CreateDocument();
        wordDocument.Open();

        DocumentFactory pdfFactory = new PdfFactory();
        IDocument pdfDocument = pdfFactory.CreateDocument();
        pdfDocument.Open();

        DocumentFactory excelFactory = new ExcelFactory();
        IDocument excelDocument = excelFactory.CreateDocument();
        excelDocument.Open();
    }
}
