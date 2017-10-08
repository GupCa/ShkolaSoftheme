using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XML_Library
{
    [Serializable]
    public class Library
    {
        public Book[] Books { get; }
        private string _fileName;

        public Library()
        {
            Books = new[]
            {
                new Book("SecretBook1", "SecretAuthor1"),
                new Book("Book2", "Author1"),
                new Book("Book3", "Author2"),
                new Book("Book4", "Author3"),
                new Book("Book5", "Author4"),
                new Book("Book6", "Author5"),
                new Book("Book7", "Author6")
            };
        }

        public Book this[int index]
        {
            get { return Books[index]; }
            set { Books[index] = value; }
        }

        public void SetFileName(string fileName)
        {
            _fileName = fileName;
        }

        public void CreateXmlFile()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Book[]));

            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }

            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this.Books);
            }
        }

        public  bool Find(Book book)
        {
            XDocument doc = XDocument.Load(_fileName);

            foreach (var element in doc.Root.Elements())
            {
                if (element.Elements("Name").Any(b => b.Value == book.Name) &&
                    element.Elements("Author").Any(b => b.Value == book.Author))
                {
                    return true;
                };
            }
            return false;
        }

        public  void ShowSelect()
        {
            XDocument doc = XDocument.Load(_fileName);

            //realisation without linq for testing

            //foreach (var element in doc.Root.Elements())
            //{
            //    foreach (var node in element.Elements())
            //    {
            //        Console.WriteLine("name = {0}; value = {1}", node.Name, node.Value);
            //    }
            //}

            foreach (var element in doc.Root.Elements().SelectMany(x => x.Elements()))
            {
                Console.WriteLine("nameOfNode = {0}; value = {1}", element.Name, element.Value);
            }
        }

        public void Add(Book book)
        {
            XDocument doc = XDocument.Load(_fileName);

            XElement bookElement = new XElement("Book",
                new XElement("Name", book.Name),
                new XElement("Author", book.Author));
            doc.Root.Add(bookElement);
            doc.Save(_fileName);
        }


        public Library Extract()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Book[]));

            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                var newLibrary = (Library)formatter.Deserialize(fs);

                return newLibrary;
            }
        }
    }
}