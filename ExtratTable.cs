using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

public class ExtratTable {

    public static void Execute(string  path) {
        // Load the PDF document
        PdfDocument pdfDoc = new PdfDocument(new PdfReader(path));

        // Create a table listener
        LocationTextExtractionStrategy tableListener = new LocationTextExtractionStrategy();
        PdfCanvasProcessor parser = new PdfCanvasProcessor(tableListener);

        // Identify the table area
        float x1 = 100;
        float y1 = 100;
        float x2 = 500;
        float y2 = 400;
        // parser.SetRegion(new Rectangle(x1, y1, x2 - x1, y2 - y1));

        // Process the PDF document
        int pageNumber = 1; // the page number where the table is located
        // parser.ProcessPage(pdfDoc.GetPage(pageNumber));

        // Get the table data
        string tableData = tableListener.GetResultantText();

        // Close the PDF document
        pdfDoc.Close();
    }
}