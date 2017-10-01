using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication_ValidateLibrary
{
    public class OnlyForViewingValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var secretBook = value as Book;
            if (secretBook != null && secretBook.Name == "SecretBook1" && secretBook.Author == "SecretAuthor1")
            {
                ErrorMessage = "This book is only for library";
                return false;
            }
            return true;
        }
    }
}