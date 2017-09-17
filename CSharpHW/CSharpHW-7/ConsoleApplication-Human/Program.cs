using System;
using System.Collections.Generic;

namespace ConsoleApplication_Human
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var human1 = new Human();
            
            var dateOfBirth = new DateTime(1997, 2, 18);
            var human2 = new Human(dateOfBirth, "Ann", "Tytova");

            var human3 = human2;
            
            var human4 = new Human(dateOfBirth, "Ann", "Tytova");
            
            var isEqual = human4.Equals(human2);
            Console.WriteLine("Is equal: {0}",isEqual);
        }
    }
}