using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReArchieve
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to a folder:");
            var path = Console.ReadLine();
            var unArchieves = new ReArchieve();
            unArchieves.Start(path);
            Console.ReadKey();
        }
    }
}
