using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to a folder:");
            var path = Console.ReadLine();
            Console.WriteLine("Enter a string to replace:");
            var stringToReplace = Console.ReadLine();
            Console.WriteLine("Enter a string that replace:");
            var stringThatReplace = Console.ReadLine();
            var stringReplacer = new StringReplaser();
            stringReplacer.Start(path, stringToReplace, stringThatReplace);
            Console.ReadKey();
        }
    }
}
