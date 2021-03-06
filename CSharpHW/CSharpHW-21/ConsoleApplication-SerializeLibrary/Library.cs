﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication_ValidateLibrary
{
    [Serializable]
    public class Library
    {
        private readonly Book[] _books;

        public Library()
        {
            _books = new[]
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

        public bool Contains(Book book)
        {
            foreach (var eachbook in _books)
            {
                if (eachbook.Name == book.Name && eachbook.Author == book.Author)
                {
                    return true;
                }
            }
            return false;
        }

        public int Length
        {
            get { return _books.Length; }
        }

        public Book this[int index]
        {
            get { return _books[index]; }
            set { _books[index] = value; }
        }

        public void ShowLibraryInfo()
        {
            Console.WriteLine("Library contains {0} books.", this.Length);
            for (var i = 0; i < this.Length; i++)
            {
                Book currentBook = this[i];
                Console.WriteLine(currentBook.Name);
            }
            Console.WriteLine();
        }
    }
}