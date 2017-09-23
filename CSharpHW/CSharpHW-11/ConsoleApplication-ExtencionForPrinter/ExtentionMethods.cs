using System;
using ConsoleApplication_Printer;

namespace ConsoleApplication_ExtencionForPrinter
{
    public static class ExtentionMethods
    {
        public static void Print(this Printer printer, string[] text)
        {
            foreach (var line in text)
            {
                printer.Print(line);
            }
        }
        
        public static void PrintColor(this ColourPrinter colorPrinter, string[] text, ConsoleColor color)
        {
            foreach (var line in text)
            {
                colorPrinter.Print(line, color);
            }
        }
        
        public static void PrintPhoto(this PhotoPrinter photoPrinter, Photo[] photos)
        {
            foreach (var photo in photos)
            {
                photoPrinter.Print(photo);
            }
        }
        
    }
}