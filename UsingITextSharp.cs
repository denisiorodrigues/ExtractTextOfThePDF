// using iTextSharp.text.pdf;
// using iTextSharp.text.pdf.parser;
// using iTextSharp.text.pdf;
// using iTextSharp.text.pdf.parser;
// using System.Collections.Generic;
// using System.Text;

// public class UsingITextSharp
// {
//     public static void Extract()
//     {
//         string fileName = "cnis";
//         string relativePath = "files/" + fileName;
//         string absolutePath = System.IO.Path.GetFullPath(relativePath);

//         Console.WriteLine("Iniciando o processo do arquivo");

//         PdfReader reader = new PdfReader($"{absolutePath}.pdf");
//         using (StreamWriter writer = new StreamWriter($"{absolutePath}_itextsharp_{DateTime.Now.ToString("yyyMMdd-mmss")}.txt"))
//         {
//             for (int page = 1; page <= reader.NumberOfPages; page++)
//             {
//                 string text = PdfTextExtractor.GetTextFromPage(reader, page);
//                 writer.WriteLine(text);
//             }
//         }

//         Console.WriteLine(new string('*', 100));
//         Console.WriteLine("The process ITextSharp ended");
//         Console.WriteLine(new string('*', 100));

//         var table = ExtractPdfTable("input.pdf", 1, 36f, 788f, 559f, 300f);

//         foreach (var row in table)
//         {
//             foreach (var cell in row)
//             {
//                 Console.Write(cell + "\t");
//             }

//             Console.WriteLine();
//         }

//         reader.Close();
//     }



//     public static List<List<string>> ExtractPdfTable(string pdfFilePath, int pageNumber, float left, float top, float right, float bottom)
//     {
//         var result = new List<List<string>>();
//         var reader = new PdfReader(pdfFilePath);
//         var strategy = new LocationTextExtractionStrategy();

//         var page = pageNumber;
//         var rectangle = new iTextSharp.text.Rectangle(left, bottom, right, top);
//         var filter = new RegionTextRenderFilter(rectangle);

//         strategy.RenderFilter = filter;

//         var text = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
//         var lines = text.Split('\n');

//         foreach (var line in lines)
//         {
//             var items = line.Split('\t');
//             result.Add(new List<string>(items));
//         }

//         reader.Close();

//         return result;
//     }

// }
