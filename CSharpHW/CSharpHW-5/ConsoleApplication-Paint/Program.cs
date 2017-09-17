using System;
using System.Collections.Generic;

namespace ConsoleApplication_Paint
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a figure: (1 - Triangle, 2 - Square, 3 - Romb)");
                var figure = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose a size: ");
                var size = Convert.ToInt32(Console.ReadLine());
                
                Paint(figure, size);
                
                Console.WriteLine("Do you want to continue? (Y/N)");
                if (Console.ReadLine() == "N" ) 
                    break;
            }
           
        }

        private static void Paint(int figure, int size)
        {
            switch (figure)
            {
                case 1:
                    PaintTriangle(size);
                    break;
                case 2:
                    PaintSquare(size);
                    break;
                case 3:
                    PaintRomb(size);
                    break;
                default:
                    Console.WriteLine("Smth is missing");
                    break;
            }
        }

        private static void PaintTriangle(int size)
        {
            for (var i = 0; i < size; i++)
            {
                for(var j = 0; j < i; j++)
                {
                    Console.Write("*");
                }  
                Console.WriteLine();
            }
        }
        
        private static void PaintSquare(int size)
        {
            for (var i = 0; i < size; i++)
            {
                for(var j = 0; j < size; j++)
                {
                    Console.Write("*");
                }  
                Console.WriteLine();
            }
            
        }
        
        private static void PaintRomb(int size)
        {
            for (var i = 0; i < size/2; i++)
            {
                for (var j = 0; j < (size/2 - i); j++)
                    Console.Write(" ");
                for (var j = 0; j < (1 + 2*i); j++)
                    Console.Write("*");
                
                Console.WriteLine();
            }
 
            for (var i = size/2 ; i >= 0; i--)
            {
                for (var j = 0; j < (size/2 - i); j++)
                    Console.Write(" ");
                for (var j = 0; j < (1 + 2*i); j++)
                    Console.Write("*");
                
                Console.WriteLine();
            }
        }
    }
}