using System;
using System.Collections.Generic;

namespace ConsoleApplication_CopyUser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var user1 = new User();
            user1.IdUser = 123;
            user1.Login = "Ann";
            user1.Array = new[] {4, 5, 6};
            user1.MyClassVal = new MyClass{MyType = 789};

            Print(user1);
            
            var user2 = (User)user1.Clone();
            
            Print(user2);
            
            user1.IdUser = 345;
            user1.Login = "Vlad";
            user1.Array[0] = 10;
            user1.MyClassVal.MyType = 678;

            Print(user1);
            Print(user2);
        }

        public static void Print(User user)
        {
            Console.Write("Id: {0}\nLogin: {1}\nArray: ", user.IdUser,user.Login);
            foreach (var i in user.Array)
            {
                Console.Write(i);
            }
            
            Console.WriteLine("\nMyClassValue: {0}\n",user.MyClassVal.MyType);
        }
    }
}