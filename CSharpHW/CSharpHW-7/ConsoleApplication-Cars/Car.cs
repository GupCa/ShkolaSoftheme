using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication_Cars
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public Colors Color { get; set; }

        public void Print()
        {
            Console.WriteLine("Model: {0}\nYear: {1}\nColor: {2}\n", Model, Year, Color);
        }
    }
}