﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Serialization;
using System.IO.Compression;

namespace ConsoleApplication_MobileOperator
{
    [Serializable]
    public class MobileAccount
    {
        public delegate void SendMessageDelegate(MobileAccount sender, int number, string message);

        public delegate void MakeACallDelegate(MobileAccount sender, int number);

        public event SendMessageDelegate Smsed;
        public event MakeACallDelegate Called;

        public MobileAccount()
        {
            Number = 0;
            AddresBook =new Dictionary<int, string>();
        }

        public MobileAccount(int number)
        {
            Number = number;
            AddresBook = new Dictionary<int, string>();
        }

        public Dictionary<int, string> AddresBook { get; }

        public int Number { get; set; }

        public void SendMessage(int numberReceiver, string message)
        {
            Smsed?.Invoke(this, numberReceiver, message);
        }

        public void ReceiveMessage(int numberSender, string message)
        {
            var nameInAddresBook = AddresBook.SingleOrDefault(x => x.Key == numberSender);

            if (nameInAddresBook.Value != default(string))
            {
                Console.WriteLine($"SMS from {nameInAddresBook.Value} to {this.Number} : {message}");
                return;
            }

            Console.WriteLine($"SMS from {numberSender} to {this.Number} : {message}");
        }

        public void MakeCall(int numberReceiver)
        {
            Called?.Invoke(this, numberReceiver);
        }

        public void ReceiveCall(int numberSender)
        {
            var nameInAddresBook = AddresBook.SingleOrDefault(x => x.Key == numberSender);

            if (nameInAddresBook.Value != default(string))
            {
                Console.WriteLine($"Call from {nameInAddresBook.Value} to {this.Number}");
                return;
            }

            Console.WriteLine($"Call from {numberSender} to {this.Number}");
        }
    }
}