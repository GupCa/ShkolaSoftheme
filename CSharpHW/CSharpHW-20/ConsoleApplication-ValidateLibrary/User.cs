using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication_ValidateLibrary
{
    public class User
    {
        [Required(ErrorMessage = "User identificator was not specified")]
        public string Id { get; set; }

        [Required(ErrorMessage = "User name was not specified")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Wrong name length")]
        public string Name { get; set; }
        
        [Required]
        [Range(1, 100, ErrorMessage = "Wrong age")]
        public int Age { get; set; }
    }
}