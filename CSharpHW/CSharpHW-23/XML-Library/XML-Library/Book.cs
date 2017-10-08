using System;

namespace XML_Library
{
    [Serializable]
    public class Book
    {
        Book()
        {
            Name = "";
            Author = "";
        }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }
        
        public string Name { get; set; }
        
        public string Author { get; set; }
    }
}