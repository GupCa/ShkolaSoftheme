using System;
using System.Collections;

namespace ConsoleApplication_MyGenerics
{
    public class MyDictionary<TKey, TValue> : DictionaryBase
    {
        public TKey this[TKey key]
        {
            get { return((TKey) Dictionary[key]); }
            set { Dictionary[key] = value; }
        }

        public ICollection Keys => (Dictionary.Keys);

        public ICollection Values => (Dictionary.Values);

        public void Add(TKey key, TValue value)
        {
            Dictionary.Add(key, value);
        }

        public void Remove(TKey key)
        {
            Dictionary.Remove(key);
        }

        public void Print(MyDictionary<TKey, TValue> myDictionary)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();

            foreach (DictionaryEntry myD in myDictionary)
            {
                Console.WriteLine("   {0,-5} : {1}", myD.Key, myD.Value);
            }
            Console.ResetColor();
        }
    }
}