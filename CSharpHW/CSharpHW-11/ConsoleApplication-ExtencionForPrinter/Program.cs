using System;
using System.Collections.Generic;
using ConsoleApplication_Printer;

namespace ConsoleApplication_ExtencionForPrinter
{
    internal class Program
    {   
        public static void Main(string[] args)
        {
            var printer = new Printer();
            var text = new String[] { "line1", "line2", "line3" };
            
            printer.Print(text);
            
            var photoPrinter = new PhotoPrinter();
            var photo1 = new Photo("Photo with friends");
            var photo2 = new Photo("Selfie");
            var photos = new Photo[] {photo1, photo2};
            
            photoPrinter.PrintPhoto(photos);
            
            var colorPrinter = new ColourPrinter();
            
            colorPrinter.PrintColor(text, ConsoleColor.DarkGray);
        }
    }
}
