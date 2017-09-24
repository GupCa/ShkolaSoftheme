using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication_MobileOperator
{
    public class MobileOperator
    {
        private readonly IList<MobileAccount> _mobileAccounts = new List<MobileAccount>();

        public void AddAccount(MobileAccount mobileAccount)
        {
            _mobileAccounts.Add(mobileAccount);
            mobileAccount.Smsed += SendMessage;
            mobileAccount.Called += MakeCall;
        }
        
        private void SendMessage(MobileAccount sender, int numberReceiver, string message)
        {
            var receiver = _mobileAccounts.Single(x => x.Number == numberReceiver);
            receiver.ReceiveMessage(sender.Number, message);
        }
        
        public void MakeCall(MobileAccount sender, int numberReceiver)
        {
            var receiver = _mobileAccounts.Single(x => x.Number == numberReceiver);
            receiver.ReceiveCall(sender.Number);
        }
        
        //маршрутизация
    }
}