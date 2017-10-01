using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication_MobileOperator
{
    public class MobileOperator
    {
        private readonly IList<MobileAccount> _mobileAccounts = new List<MobileAccount>();
        
        private readonly Dictionary<int, int> _callLog  = new Dictionary<int, int>();
        
        private readonly Dictionary<int, double> _callAccountLog  = new Dictionary<int, double>();

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
            
            if (_callLog.ContainsKey(numberReceiver) == false)
            {
                _callLog.Add(numberReceiver, 1);
            }
            else
            {
                _callLog[numberReceiver]++;
            }
            
            if (_callAccountLog.ContainsKey(sender.Number) == false)
            {
                _callAccountLog.Add(sender.Number, 0.5);
            }
            else
            {
                _callAccountLog[sender.Number]+=0.5;
            }
        }

        public void MakeCall(MobileAccount sender, int numberReceiver)
        {
            var receiver = _mobileAccounts.Single(x => x.Number == numberReceiver);
            receiver.ReceiveCall(sender.Number);
            
            if (_callLog.ContainsKey(numberReceiver) == false)
            {
                _callLog.Add(numberReceiver, 1);
            }
            else
            {
                _callLog[numberReceiver]++;
            }
            
            if (_callAccountLog.ContainsKey(sender.Number) == false)
            {
                _callAccountLog.Add(sender.Number, 1);
            }
            else
            {
                _callAccountLog[sender.Number]+=1;
            }
        }

        public IEnumerable<KeyValuePair<int, int>> GetTopFiveFrequentlyAskedAccounts()
        {
            var topFive = _callLog.OrderByDescending(x => x.Value).Take(5);

            return topFive;
        }
        
        public IEnumerable<KeyValuePair<int, double>> GetTopFiveActiveAccounts()
        {
            var topFive = _callAccountLog.OrderByDescending(x => x.Value).Take(5);

            return topFive;
        }
    }
}