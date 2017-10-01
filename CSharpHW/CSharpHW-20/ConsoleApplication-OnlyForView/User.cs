using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication_ValidateLibrary
{
    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }
        
        public int Age { get; set; }

        public void GetBook(Library library, Book book)
        {
            if (library.Contains(book) == true && Valids.ValidateBook(book) == true)
            {
                Console.WriteLine("User {0} take a book {1}", Name, book.Name);
            }
            else
            {
                Console.WriteLine("User {0} cant take a book {1}", Name, book.Name);
            }
        }
    }
}