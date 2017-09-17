using System;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //string number1, number2, sign;
            //double number1Double, number2Double;
            
            Console.WriteLine("input first number");
            var number1 = Console.ReadLine();
            var number1Double = double.Parse(number1);
            
            Console.WriteLine("input sign");
            var sign = Console.ReadLine();
            
            Console.WriteLine("input second number");
            var number2 = Console.ReadLine();
            var number2Double = double.Parse(number2);

            switch (sign)
            {
                case "+":
                    Console.WriteLine("The answer is {0:0.00}", number1Double + number2Double);
                    break;
                    
                case "-":
                    Console.WriteLine("The answer is {0:0.00}", number1Double - number2Double);
                    break;    
                    
                case "*":
                    Console.WriteLine("The answer is {0:0.00}", number1Double * number2Double);
                    break;    
                
                case "/":
                case ":":    
                    Console.WriteLine("The answer is {0:0.00}", number1Double / number2Double);
                    break;   
                    
                default: 
                    Console.WriteLine("There is no answer");
                    break;
            }
            
        }
    }
}