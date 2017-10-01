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
            Valids.ValidateBook(library[0]);


            Console.WriteLine("Input name:");
            var name = Console.ReadLine();

            Console.WriteLine("Input age:");
            var age = int.Parse(Console.ReadLine());

            var user = new User {Name = name, Age = age};

            Valids.ValidateUser(user);
        }
    }
}