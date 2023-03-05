// using iTextSharp.text.pdf;
// using iTextSharp.text.pdf.parser;
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         PdfReader reader = new PdfReader("yourfile.pdf");
//         string text = PdfTextExtractor.GetTextFromPage(reader, 1, new LocationTextExtractionStrategy());
//         Console.WriteLine(text);
//         reader.Close();
//     }
// }

using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


string fileName = "cnis";
string relativePath = "files/" + fileName;
string absolutePath = System.IO.Path.GetFullPath(relativePath);

Console.WriteLine("Iniciando o processo do arquivo");

PdfReader reader = new PdfReader($"{absolutePath}.pdf");
using (StreamWriter writer = new StreamWriter($"{absolutePath}.txt"))
{
    for (int page = 1; page <= reader.NumberOfPages; page++)
    {
        string text = PdfTextExtractor.GetTextFromPage(reader, page);
        writer.WriteLine(text);
    }
}

Console.WriteLine("Processo encerrado");

reader.Close();
