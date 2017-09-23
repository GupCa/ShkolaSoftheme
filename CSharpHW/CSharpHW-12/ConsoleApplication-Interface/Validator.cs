namespace ConsoleApplication_Interface
{
    public class Validator : IValidator
    {
        public string Password { get; set; }

        public bool ValidateUser(IUser user)
        {
            if (user.Password.Equals(this.Password))
            {
                return true;
            }

            return false;
        }
    }
}