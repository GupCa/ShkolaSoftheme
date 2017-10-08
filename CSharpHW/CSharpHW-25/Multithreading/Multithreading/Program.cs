using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to a folder:");
            var path = Console.ReadLine();
            var archieves = new Archieve();
            archieves.Start(path);
            Console.ReadKey();
        }
    }
}
