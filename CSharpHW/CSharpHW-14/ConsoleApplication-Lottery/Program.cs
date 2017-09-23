using System;
using System.Collections.Generic;

namespace ConsoleApplication_Lottery
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lottery = new LotteryIndex();
            lottery.GetNumbers();

            for (var i = 0; i < 6; i++)
            {
                Console.Write("If the {0}-th number is guessed: {1}\n", i + 1, lottery[i]);
            }
            Console.WriteLine();
        }
    }
}