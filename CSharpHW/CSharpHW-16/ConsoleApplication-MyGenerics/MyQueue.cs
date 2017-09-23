using System;
using System.Collections.Generic;

namespace ConsoleApplication_MyGenerics
{
    public class MyQueue<T>
    {
        private T[] _array;
        private int _i = 0;

        public MyQueue()
        {
            T[] a = new T[] { };
            this._array = a;
        }

        public MyQueue(int capacity)
        {
            if (capacity < 0)
            {
                T[] a = new T[] { };
                this._array = a;
            }

            this._array = new T[capacity];
        }

        public MyQueue(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                T[] a = new T[] { };
                this._array = a;
            }

            this._array = new T[4];
            foreach (T obj in collection)
                this.Enqueue(obj);
        }

        public void Enqueue(T item)
        {
            if (_i + 1 > _array.Length)
            {
                T[] newArray = new T[_array.Length + 20];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                newArray[_i] = item;
                _array = newArray;
                _i++;
            }
            else
            {
                _array[_i] = item;
                _i++;
            }
        }
        
        public T Peek()
        {
            if (_i > 0)
            {
                return _array[0];
            }
            else
            {
                return default(T);
            }
        }

        public T Dequeue()
        {
            for (int i = 0; i < _i; i++)
            {
                if (i + 1 == _array.Length)
                {
                    _array[i] = default(T);
                    _i--;
                    return Peek();
                }
                else
                {
                    _array[i] = _array[i + 1];
                }
                
            }
            _i--;
            return Peek();
        }

        public void Print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < _i; i++)
            {
                Console.Write(" {0}", _array[i].ToString());
            }
            Console.ResetColor();
        }
    }
}