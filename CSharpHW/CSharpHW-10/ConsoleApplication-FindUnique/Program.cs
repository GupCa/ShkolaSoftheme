using System;
using System.Collections.Generic;

namespace ConsoleApplication_FindUnique
{
    internal class Program
    {
        private const int ArrayLenght = 10001;
        private const int UniqueValue = 228;
        private const int MinRandomValue = 0;
        private const int MaxRandomValue = 101;
        
        public static void Main(string[] args)
        {
            var randomArray = new int[ArrayLenght] ;
            
            GenerateSequence(randomArray);
            //Print(randomArray);
            FindUnique(randomArray);
        }

        public static void GenerateSequence(int[] randomArray)
        {
            var rnd = new Random();
            
            randomArray[0] = UniqueValue;
            for (var i = 1; i < ArrayLenght; i = i+2)
            {
                var buffer = rnd.Next(MinRandomValue, MaxRandomValue);
                randomArray[i] = buffer;
                randomArray[i+1] = buffer;
            }

            for (var i = 0; i < ArrayLenght*2; i++)
            {
                var randomIndex1 = rnd.Next(0, ArrayLenght);
                var randomIndex2 = rnd.Next(0, ArrayLenght);
                
                var buffer = 0;
                
                buffer = randomArray[randomIndex1];
                randomArray[randomIndex1] = randomArray[randomIndex2];
                randomArray[randomIndex2] = buffer;
            }
        }

        public static void Print(int[] randomArray)
        {
            foreach (var i in randomArray)
            {
                if (i == UniqueValue)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.Write(" {0}",i);
                Console.ResetColor();
            }
        }

        public static void FindUnique(int[] randomArray)
        {
            var additionalArray = new int[ArrayLenght];
            var additionalIndex = 0;

            for (var i = 0; i < ArrayLenght; i++)
            {
                var inArray = false;
                var j = 0;
                
                for (j = 0; j < additionalArray.Length; j++)
                { 
                    if (randomArray[i] == additionalArray[j])
                    {
                        inArray = true;
                        break;
                    }
                }

                if (!inArray)
                {
                    additionalArray[additionalIndex] = randomArray[i];
                    additionalIndex++;
                }
                else 
                {
                    additionalArray[j] = 0;
                }
            }

            foreach (var i in additionalArray)
            {
                if (i != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n {0}", i);
                }
            }
        }
    }
}