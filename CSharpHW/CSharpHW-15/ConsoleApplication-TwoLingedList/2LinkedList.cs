using System;
using System.Collections.Generic;

namespace ConsoleApplication_TwoLingedList
{
    public class TwoLinkedList<T>
    {
        private TwoLinkedListNode<T> _start;
        public int Length { get; set; }


        public void Add(TwoLinkedListNode<T> node)
        {
            if (_start == null)
            {
                _start = node;
                Length++;
            }
            else
            {
                node.Next = _start;
                node.Previous = _start.Previous;
                _start.Previous = node;
                _start = node;
                Length++;
            }
        }

        public void Add(T value)
        {
            var node = new TwoLinkedListNode<T>(null, null, value);

            if (_start == null)
            {
                _start = node;
                Length++;
            }
            else
            {
                node.Next = _start;
                node.Previous = _start.Previous;
                _start.Previous = node;
                _start = node;
                Length++;
            }
        }

        public TwoLinkedList()
        {
        }

        public TwoLinkedList(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection");
            }

            foreach (T obj in collection)
            {
                Add(obj);
            }
        }

        public bool Contain(T item)
        {
            if (Find(item) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TwoLinkedListNode<T> Find(T value)
        {
            TwoLinkedListNode<T> linkedListNode = _start;

            if (this._start != null)
            {
                while (((object) linkedListNode.Item != null))
                {
                    if (linkedListNode.Item.Equals(value))
                    {
                        return linkedListNode;
                    }
                    if (linkedListNode.Next != null)
                    {
                        linkedListNode = linkedListNode.Next;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }

        public void Delete(T value)
        {
            TwoLinkedListNode<T> nodeToDelete = Find(value);

            if (nodeToDelete == null)
            {
                return;
            }

            if (nodeToDelete == _start)
            {
                _start = null;
                Length--;
                return;
            }

            if (nodeToDelete.Next == null)
            {
                nodeToDelete.Previous.Next = null;
                Length--;
            }
            else if (nodeToDelete.Previous == null)
            {
                nodeToDelete.Next.Previous = null;
                Length--;
            }
            else
            {
                nodeToDelete.Next.Previous = nodeToDelete.Previous;
                nodeToDelete.Previous.Next = nodeToDelete.Next;
                Length--;
            }
        }

        public T[] ToArray()
        {
            TwoLinkedListNode<T> linkedListNode = _start;
            var array = new T[Length];

            if (this._start != null)
            {
                var i = 0;
                while (((object) linkedListNode.Item != null))
                {
                    array[i] = linkedListNode.Item;
                    i++;
                    if (linkedListNode.Next != null)
                    {
                        linkedListNode = linkedListNode.Next;
                    }
                    else
                    {
                        return array;
                    }
                }
            }
            return null;
        }

        public void Show()
        {
            TwoLinkedListNode<T> linkedListNode = _start;

            if (this._start != null)
            {
                while ((object) linkedListNode.Item != null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.Write(" {0} ", linkedListNode.Item.ToString());

                    if (linkedListNode.Next != null)
                    {
                        linkedListNode = linkedListNode.Next;
                    }
                    else
                    {
                        Console.ResetColor();
                        return;
                    }
                }
                Console.ResetColor();
            }
        }
    }
}