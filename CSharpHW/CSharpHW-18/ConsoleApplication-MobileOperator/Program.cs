using System;
using System.Collections.Generic;

namespace ConsoleApplication_MobileOperator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var account1 = new MobileAccount(123);
            var account2 = new MobileAccount(345);
            
            account1.AddresBook.Add(account2.Number, "Vlad");
            account2.AddresBook.Add(account1.Number, "Ann");
            
            var mobileOperator = new MobileOperator();
            mobileOperator.AddAccount(account1);
            mobileOperator.AddAccount(account2);
            
            account1.SendMessage(account2.Number, "hello");
            account2.MakeCall(account1.Number);

        }
    }
}