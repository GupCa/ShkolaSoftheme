using System;
using System.Collections.Generic;

namespace ConsoleApplication_Sort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var randomArray = new int[100];
            GenerateArray(randomArray);
            Print(randomArray, ConsoleColor.DarkMagenta);
            BubbleSort(randomArray);
            Print(randomArray, ConsoleColor.DarkCyan);
        }
        
        public static void GenerateArray(int[] randomArray)
        {
            var rnd = new Random();
            
            for (var i = 0; i < randomArray.Length; i++)
            {
                randomArray[i]= rnd.Next(0, 1000);
            }
        }

        public static void Print(int[] array, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            } 
            
            Console.WriteLine();
            Console.ResetColor();
        }


        public static void BubbleSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++) 
            {
                for (var j = 0; j < array.Length - 1; j++) 
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = 0;
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        
        public 
    }
}
