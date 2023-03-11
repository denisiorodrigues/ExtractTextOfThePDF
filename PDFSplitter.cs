using System;
using System.Collections.Generic;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;

namespace ExtractTextOfThePDF
{
    public class PDFSplitter
    {
        // private static string ORIG = "/uploads/split.pdf";

        public static void Execute(string originPath)
        {
            int maxPageCount = 2; // create a new PDF per 2 pages from the original file
            PdfDocument pdfDocument = new PdfDocument(new PdfReader(new FileStream(originPath, FileMode.Open, FileAccess.Read, FileShare.Read)));
            IList <PdfDocument> splitDocuments = new CustomPdfSplitter(pdfDocument).SplitByPageCount(maxPageCount);

            foreach (PdfDocument doc in splitDocuments)
            {
                doc.Close();
            }
            
            pdfDocument.Close();
        }
    }

    public class CustomPdfSplitter : PdfSplitter
    {
        int _partNumber = 1;

        public CustomPdfSplitter(PdfDocument pdfDocument) : base(pdfDocument)
        {
        }

        protected override PdfWriter GetNextPdfWriter(PageRange documentPageRange)
        {
            try
            {
                return new PdfWriter("./newfiles/splitDocument_" + _partNumber++ + ".pdf");
            }
            catch (FileNotFoundException e)
            {
                throw new SystemException();
            }
        }
    }
}