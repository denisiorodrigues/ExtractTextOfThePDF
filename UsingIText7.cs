
using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public class UsingIText7 {
  public static void CreateHello() {
    PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream("./newfiles/hello.pdf", FileMode.Create, FileAccess.Write)));
    Document document = new Document(pdfDocument);

    String line = "Hello! Welcome to iTextPdf";
    document.Add(new Paragraph(line));
    document.Close();
    Console.WriteLine("Awesome PDF just got created.");
  }
}