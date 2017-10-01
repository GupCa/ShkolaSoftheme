using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using ProtoBuf;

namespace ConsoleApplication_ValidateLibrary
{
    internal class Program
    {
        static void  Main()
        {
            var library = new Library();
            library.ShowLibraryInfo();

            BinarySerialisation(library);
            Protobuf(library);       
        }

        public static void BinarySerialisation(Library library)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("library.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, library);
            }
            stopWatch.Stop();
            Console.WriteLine("Binary serialization takes {0} ms", stopWatch.Elapsed.Milliseconds);
        }

        public static void Protobuf(Library library)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            using (var file = File.Create("library.bin")) 
            {
                Serializer.Serialize(file, library);
            }
            stopWatch.Stop();
            Console.WriteLine("Protobuf serialization takes {0} ms", stopWatch.Elapsed.Milliseconds);
        }

    }
}