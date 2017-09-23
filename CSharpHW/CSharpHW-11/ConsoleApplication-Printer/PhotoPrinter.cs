using System;
using System.Net.Mime;

namespace ConsoleApplication_Printer
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string message)
        {
            Console.WriteLine("PhotoPrinter message: {0}", message);
        }

        public void Print(Photo photo)
        {
            Console.WriteLine("PhotoPrinter image name: {0}", photo.Name);
        }
    }
}