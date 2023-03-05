using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

public class UsingITextSharp
{
    public static void Extract()
    {
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
    }
}
