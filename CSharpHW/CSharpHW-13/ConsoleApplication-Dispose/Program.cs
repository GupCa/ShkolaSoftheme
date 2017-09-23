using System;
using System.Collections.Generic;

namespace ConsoleApplication_Dispose
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var basers = new ResourceHolderBase();
            var derive = new ResourceHolderDerived();

            basers.Dispose();
            //derive.Dispose();
            basers.Dispose();
            //derive.Dispose();
        }
    }
}