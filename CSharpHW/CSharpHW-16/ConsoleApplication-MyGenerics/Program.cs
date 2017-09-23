using System;
using System.Collections.Generic;

namespace ConsoleApplication_MyGenerics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = new int[] {2, 5, 5};
            MyQueue<int> myQueue = new MyQueue<int>(ints);
            myQueue.Enqueue(1321);
            Console.Write("Initial queue: ");
            myQueue.Print();
            Console.Write(" Peek: {0}", myQueue.Peek());
            myQueue.Dequeue();
            Console.Write("\nDeleted");
            myQueue.Print();
            Console.Write("\nAdded");
            myQueue.Enqueue(47);
            myQueue.Print();

            MyStack<int> myStack = new MyStack<int>(ints);
            Console.Write("\nInitial stack: ");
            myStack.Print();
            myStack.Push(1321);
            myStack.Push(65);
            Console.Write("\nAdded");
            myStack.Print();
            Console.Write(" Peek: {0}", myStack.Peek());
            myStack.Pop();
            Console.Write("\nDeleted");
            myStack.Print();


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(178, "gf");
            myDictionary.Add(687, "j");
            myDictionary.Add(978, "slkds");
            myDictionary.Add(354, "adfsgg");
            myDictionary.Add(154, "lskg");
           
            Console.Write("\nInitial dictionary: ");
            myDictionary.Print(myDictionary);
            myDictionary.Remove(978);
            Console.Write("Deleted");
            myDictionary.Print(myDictionary);
        }
    }
}