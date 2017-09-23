using Microsoft.SqlServer.Server;

namespace ConsoleApplication_Interface
{
    public class User : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }
        public string GetFullInfo()
        {
            return $"Name/Email: {Email} {Name}\nPassword: {Password}";
        }
    }
}