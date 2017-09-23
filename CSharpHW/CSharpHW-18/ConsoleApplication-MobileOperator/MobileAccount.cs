using System;
using System.Collections.Generic;

namespace ConsoleApplication_MobileOperator
{
    public class MobileAccount
    {
        
        public delegate void Checker(string message);
        public event Checker Called;
        public event Checker Smsed;
        public Dictionary<int, string> AddresBook;

        public int Number { get; set; }

        public void SendMessage(int numberReceiver)
        {
            if (numberReceiver != 0)
            {
                Smsed($"SMS sended from {Number} to {numberReceiver}");
            }
        }
        
        public void MakeCall(int numberReceiver)
        {
            Called($"Call made from {Number} to {numberReceiver}");
        }
    }
}