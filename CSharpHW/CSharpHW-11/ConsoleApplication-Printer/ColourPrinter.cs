using System;

namespace ConsoleApplication_Printer
{
    public class ColourPrinter : Printer
    {
        public override void Print(string message)
        {
            Console.WriteLine("ColourPrinter message: {0}", message);
        }

        public void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("ColourPrinter text: {0}", text);
            Console.ResetColor();
        }
    }
}