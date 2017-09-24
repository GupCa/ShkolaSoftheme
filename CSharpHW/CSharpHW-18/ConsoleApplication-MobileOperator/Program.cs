using System;
using System.Collections.Generic;

namespace ConsoleApplication_MobileOperator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var account1 = new MobileAccount();
            account1.Number = 123;
            var account2 = new MobileAccount();
            account2.Number = 345;
            
            var mobileOperator = new MobileOperator();
            mobileOperator.AddAccount(account1);
            mobileOperator.AddAccount(account2);
            
            account1.SendMessage(345, "hello");
            account2.MakeCall(123);

        }
    }
}