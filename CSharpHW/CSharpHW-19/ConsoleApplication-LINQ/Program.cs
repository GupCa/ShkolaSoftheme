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
            
            account1.AddresBook.Add(account2.Number, "Vlad");
            account1.AddresBook.Add(account3.Number, "Mum");
            account2.AddresBook.Add(account1.Number, "Ann");
            
            //account1.Serialize();
            //var testAccount1 = account1.DeSerialize();

            account2.Zip();
            var testAccount2 = account2.Unzip();
        }
    }
}