using System;

namespace ConsoleApplication_Printer
{
    public class Printer
    {
        public virtual void Print(string message)
        {
            Console.WriteLine("Printer message: {0}", message);
        }
    }
}