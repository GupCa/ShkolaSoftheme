using System;
using System.Collections.Generic;

namespace ConsoleApplication_Interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User[] work = new User[]
            {
                new User("Ann", "12345", ""),
                new User("Vlad", "12345", ""),
            };

            Do(work);
        }

        public static void Do(User[] work)
        {
            var user = new User("", "", "");

            Console.Write("\nName/Email : ");
            var line = Console.ReadLine();
            if (line.Contains("@") == true)
            {
                user.Email = line;
            }
            else
            {
                user.Name = line;
            }

            Console.Write("Password : ");
            user.Password = Console.ReadLine();

            if ((user.Name.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                 user.Email.Equals("exit", StringComparison.OrdinalIgnoreCase)) &&
                 user.Password.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var isInArray = false;

            for (int i = 0; i < work.Length; i++)
            {
                if (work[i].Email.Equals(user.Email, StringComparison.OrdinalIgnoreCase) && 
                    !(work[i].Email.Equals("")) ||
                    work[i].Name.Equals(user.Name, StringComparison.OrdinalIgnoreCase) &&
                    !(work[i].Name.Equals("")))
                {
                    isInArray = true;
                    var validator = new Validator();
                    validator.Password = work[i].Password;

                    if (validator.ValidateUser(user))
                    {
                        Console.WriteLine("This user last time online was {0}", DateTime.Now);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unsuccesfull validation of password");
                    }
                }
            }

            if (!isInArray)
            {
                var workWithUser = new User[work.Length + 1];
                for (int i = 0; i < work.Length; i++)
                {
                    workWithUser[i] = work[i];
                }
                workWithUser[work.Length] = new User(user.Name, user.Password, user.Email);
                Do(workWithUser);
            }
            else
            {
                Do(work);
            }
        }
    }
}