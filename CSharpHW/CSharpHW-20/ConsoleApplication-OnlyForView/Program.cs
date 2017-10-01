using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication_ValidateLibrary
{
    internal class Program
    {
        static void Main()
        {
            var library = new Library();
            library.ShowLibraryInfo();

            var user = new User {Id = "1432", Name = "Ann", Age = 20};
            user.GetBook(library, library[0]);
        }
    }
}