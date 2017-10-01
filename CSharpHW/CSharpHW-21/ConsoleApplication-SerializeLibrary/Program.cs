using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace ConsoleApplication_ValidateLibrary
{
    internal class Program
    {
        static void  Main()
        {
            var library = new Library();
            library.ShowLibraryInfo();

            BinarySerialisation(library);
            XmlSerialization(library);
            JsonSerialization(library);
            SoapSerialization(library);
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

        public static void XmlSerialization(Library library)
        {
            Stopwatch stopWatch = new Stopwatch();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Library));
            stopWatch.Start();

            using (FileStream fs = new FileStream("library.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, library);
            }
            
            stopWatch.Stop();
            Console.WriteLine("XML serialization takes {0} ms", stopWatch.Elapsed.Milliseconds);
        }

        public static void JsonSerialization(Library library)
        {
            Stopwatch stopWatch = new Stopwatch();
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(Library));
            stopWatch.Start();
            
            using (FileStream fs = new FileStream("library.xml", FileMode.OpenOrCreate))
            {
                dataContractJsonSerializer.WriteObject(fs, library);
            }
            stopWatch.Stop();
            Console.WriteLine("Json serialization takes {0} ms", stopWatch.Elapsed.Milliseconds);
        }

        public static void SoapSerialization(Library library)
        {
            Stopwatch stopWatch = new Stopwatch();
            SoapFormatter soapFormatter = new SoapFormatter();
            stopWatch.Start();

            using (FileStream fs = new FileStream("library.dat", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, library);
            }
            stopWatch.Stop();
            Console.WriteLine("Soap serialization takes {0} ms", stopWatch.Elapsed.Milliseconds);
        }
    }
}