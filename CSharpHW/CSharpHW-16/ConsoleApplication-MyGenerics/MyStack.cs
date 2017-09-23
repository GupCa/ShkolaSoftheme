using System;
using System.Collections.Generic;

namespace ConsoleApplication_MyGenerics
{
    public class MyStack<T>
    {
        private T[] _array;
        private int _i = 0;

        public MyStack()
        {
            T[] a = new T[] { };
            this._array = a;
        }

        public MyStack(int capacity)
        {
            if (capacity < 0)
            {
                T[] a = new T[] { };
                this._array = a;
            }

            this._array = new T[capacity];
        }

        public MyStack(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                T[] a = new T[] { };
                this._array = a;
            }

            this._array = new T[4];
            foreach (T obj in collection)
                this.Push(obj);
        }

        public void Push(T item)
        {
            if (_i + 1 > _array.Length)
            {
                T[] newArray = new T[_array.Length + 20];
                for (int i = _i; i > 0; i--)
                {
                    newArray[i] = _array[i - 1];
                }
                _array = newArray;
                _array[0] = item;
                _i++;
            }
            else
            {
                for (int i = _i; i > 0; i--)
                {
                    _array[i] = _array[i - 1];
                }
                _array[0] = item;
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

        public T Pop()
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < _i; i++)
            {
                Console.Write(" {0}", _array[i].ToString());
            }
            Console.ResetColor();
        }
    }
}