using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace ConsoleApplication_MobileOperator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var account1 = new MobileAccount(123);
            var account2 = new MobileAccount(345);
            var account3 = new MobileAccount(587);
            var account4 = new MobileAccount(512);

            var mobileOperator = new MobileOperator();
            mobileOperator.AddAccount(account1);
            mobileOperator.AddAccount(account2);
            mobileOperator.AddAccount(account3);
            mobileOperator.AddAccount(account4);
            
            account1.SendMessage(account2.Number, "hello world");
            account1.MakeCall(account3.Number);
            account1.MakeCall(account4.Number);
            account2.MakeCall(account3.Number);

            Console.WriteLine("\nTop 5 active accounts: ");
            var top5Active = mobileOperator.GetTopFiveActiveAccounts();
            foreach (var account in top5Active)
            {
                Console.Write(" {0}", account.Key);
            }
            
            Console.WriteLine("\nTop 5 asked accounts: ");
            var top5Asked = mobileOperator.GetTopFiveFrequentlyAskedAccounts();
            foreach (var account in top5Asked)
            {
                Console.Write(" {0}", account.Key);
            }
        }
    }
}