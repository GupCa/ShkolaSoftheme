using System;

namespace XML_Library
{
    internal class Program
    {
        static void  Main()
        {
            var library = new Library();
            library.SetFileName("mylibrary.xml");
            library.CreateXmlFile();
            library.ShowSelect();
            Console.WriteLine("If SecretBook1 by SecretAuthor1 is exist? {0}",
                (library.Find(new Book("SecretBook1", "SecretAuthor1"))));
            Console.WriteLine("If SecretBook1 by SomeAuthor is exist? {0}",
                (library.Find(new Book("SecretBook1", "SomeAuthor"))));
            library.Add(new Book("NewBook", "NewAuthor"));
            library.ShowSelect();
            Console.ReadKey();
        }

    }
}