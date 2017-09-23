using System;
using System.Collections.Generic;

namespace ConsoleApplication_Printer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var photo = new Photo("Picture21");
            
            var printer = new Printer();
            var colourPrinter = new ColourPrinter();
            var photoPrinter = new PhotoPrinter();

            printer.Print("line");
            
            colourPrinter.Print("colourline");
            colourPrinter.Print("colourline", ConsoleColor.DarkGreen);
            
            photoPrinter.Print("photoline");
            photoPrinter.Print(photo);

            Printer printer2 = colourPrinter;
            
            printer2.Print("(printer)colourprinter");
        }
    }
}