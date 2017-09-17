using System;
using System.Collections.Generic;

namespace ConsoleApplication_min_max
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("type\t MIN | MAX | DEFAULT ");
            Console.WriteLine("bool\t {0} | {1} | {2} ", bool.FalseString, bool.TrueString, default(bool));
            Console.WriteLine("byte\t{0} | {1} | {2} ", byte.MinValue, byte.MaxValue, default(byte));
            Console.WriteLine("sbyte\t{0} | {1} | {2} ", sbyte.MinValue, sbyte.MaxValue, default(sbyte));
            Console.WriteLine("short\t{0} | {1} | {2} ", short.MinValue, short.MaxValue, default(short));
            Console.WriteLine("ushort\t{0} | {1} | {2} ", ushort.MinValue, ushort.MaxValue, default(ushort));
            Console.WriteLine("int\t{0} | {1} | {2} ", int.MinValue, int.MaxValue, default(int));
            Console.WriteLine("uint\t{0} | {1} | {2} ", uint.MinValue, uint.MaxValue, default(uint));
            Console.WriteLine("long\t{0} | {1} | {2} ", long.MinValue, long.MaxValue, default(long));
            Console.WriteLine("ulong\t{0} | {1} | {2} ", ulong.MinValue, ulong.MaxValue, default(ulong));
            Console.WriteLine("float\t{0} | {1} | {2} ", float.MinValue, float.MaxValue, default(float));
            Console.WriteLine("double\t{0} | {1} | {2} ", double.MinValue, double.MaxValue, default(double));
            Console.WriteLine("decimal\t{0} | {1} | {2} ", decimal.MinValue, decimal.MaxValue, default(decimal));
            
        }
    }
}