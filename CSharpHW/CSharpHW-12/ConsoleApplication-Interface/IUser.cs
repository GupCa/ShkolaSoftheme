namespace ConsoleApplication_Interface
{
    public interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }

        string GetFullInfo();
    }
}