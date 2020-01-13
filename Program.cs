using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace itext.core
{
    class Program
    {
        public static string DEST = "simple_table.pdf";

        static void Main(string[] args)
        {
            FileStream file = File.Create(DEST);
            file.Close();
            manipulatePdf(DEST);
        }
    
        private static void manipulatePdf(string dest) {
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest));
            Document doc = new Document(pdfDoc);
    
            Table table = new Table(UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();
            
            for (int i = 0; i < 16; i++) {
                table.AddCell("hi");
            }

            doc.Add(table); 
            doc.Close();
        }
    }
}
