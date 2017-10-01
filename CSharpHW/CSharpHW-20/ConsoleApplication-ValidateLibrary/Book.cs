using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication_ValidateLibrary
{
    public class Book
    {
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }
        
        [Required(ErrorMessage = "Book name was not specified")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Wrong name length")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Author name was not specified")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Wrong author length")]
        public string Author { get; set; }
    }
}