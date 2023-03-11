// using iText.Kernel.Pdf;
// using TableExtractionFromPDFDLL;


// public class FilterTableEventListener
// {

//     static void Extract(string[] args)
//     {
//         PdfReader reader = new PdfReader(@"files\cnis.pdf");
//         PdfDocument document = new PdfDocument(reader);

//         //insert your required page number or loop through all pages
//         PdfPage page = document.GetPage(1);

//         FilterTableEventListener renderListener = new FilterTableEventListener(page, true);
//         System.Data.DataSet ds = renderListener.GetTables();

//         //get tables from a range of pages
//         System.Data.DataSet[] dsList = new System.Data.DataSet[document.GetNumberOfPages()];
//         int startPage = 1, index = 0;
//         int endPage = 9 < document.GetNumberOfPages() ? 9 : document.GetNumberOfPages();

//         for (int i = startPage; i <= endPage; i++)
//         {
//             PdfPage temPage = document.GetPage(i);
//             renderListener = new FilterTableEventListener(temPage, true);
//             dsList[index++] = renderListener.GetTables();
//         }

//         document.Close();
//         reader.Close();
//     }
// }