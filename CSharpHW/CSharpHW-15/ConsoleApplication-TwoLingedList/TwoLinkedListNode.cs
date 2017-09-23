using System;
using System.Collections.Generic;

namespace ConsoleApplication_TwoLingedList
{
    public class TwoLinkedListNode<T>
    {
        public TwoLinkedListNode<T> Next { get; set; }
        public TwoLinkedListNode<T> Previous { get; set; }
        public T Item { get; set; }

        

        public TwoLinkedListNode(TwoLinkedListNode<T> next, TwoLinkedListNode<T> previous, T item)
        {
            Item = item;
            Next = next;
            Previous = previous;
        }

    }
}