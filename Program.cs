using ExtractTextOfThePDF;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

public static class Program
{
    public static void Main(string[] agrs)
    {
        string pathFile = "./files/extrato.pdf";
        
        //Extract TEXT pdf with GhostScript
        //UsingMyGhostScript.Extract("cnis");
        UsingIText7.CreateHello();
        PDFSplitter.Execute(pathFile);


        // Load the PDF document
        PdfDocument pdfDoc = new PdfDocument(new PdfReader(pathFile));

        // Extract text from all pages of the PDF document
        string extractedText = "";
        for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
        {
            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            string text = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i), strategy);
            extractedText += text;
            Console.WriteLine(text);
        }

        Console.WriteLine(new string('*', 200));
        Console.WriteLine(extractedText);
        // Close the PDF document
        pdfDoc.Close();
    }
}