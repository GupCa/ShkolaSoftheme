using System;
using System.Collections.Generic;

namespace ConsoleApplication_ArrayWrapper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[4] {2, 43, 5, 6};
            var wrapper = new ArrayWrapper{Array = array};
            var addArray = new int[6] {53, 53, 744, 6, 54, 2};

            wrapper.Array = wrapper.Add(addArray);

            foreach (var number in wrapper.Array)
            {
                Console.Write(" {0} ", number);
            }
            
            Console.WriteLine("\nThe {0}-th element in array is {1} ", 8, wrapper.GetByIndex(8));
            
            Console.WriteLine("Number {0} exist in array? {1}", 744, wrapper.Contains(744));
        }
    }
}