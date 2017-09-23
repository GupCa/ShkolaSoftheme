using System;
using System.Collections.Generic;

namespace ConsoleApplication_TwoLingedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] ints =
                {54, 354, 35, 765, 75};
            var listInt = new TwoLinkedList<int>(ints);
            Console.Write("Initial list: ");
            listInt.Show();
            Console.Write(" Length: {0}", listInt.Length);

            Console.Write("\nAfter adding: ");
            listInt.Add(123);
            listInt.Show();
            Console.Write(" Length: {0}", listInt.Length);
            
            Console.Write("\nDoes list contain 7658? {0}", listInt.Contain(7658));
            Console.Write("\nDoes list contain 54? {0}", listInt.Contain(54));

            Console.Write("\nList after deleting 35:");
            listInt.Delete(35);
            listInt.Show();
            Console.Write(" Length: {0}", listInt.Length);

            Console.Write("\nList after deleting 54:");
            listInt.Delete(54);
            listInt.Show();
            Console.Write(" Length: {0}", listInt.Length);

            Console.Write("\nList after deleting 7:");
            listInt.Delete(7);
            listInt.Show();
            Console.Write(" Length: {0}", listInt.Length);

            Console.Write("\nIn array form: ");
            var array = listInt.ToArray();
            foreach (var value in array)
            {
                Console.Write(" {0} ", value);
            }
            
            Console.WriteLine("\n\nAnd also with strings: ");
            string[] strings =
                {"Tea", "Ball", "Tree", "Pen", "Flower"};
            var listString = new TwoLinkedList<string>(strings);
            Console.Write("Initial list: ");
            listString.Show();
            Console.Write(" Length: {0}", listString.Length);
        }
    }
}