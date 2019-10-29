using System;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }

        static string ReadPdf(string path) {

            using (PdfReader reader = new PdfReader(path))
            {
                System.Text.StringBuilder text = new System.Text.StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }
    }
}
