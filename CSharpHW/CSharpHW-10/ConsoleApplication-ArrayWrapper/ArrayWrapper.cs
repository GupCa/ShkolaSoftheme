using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApplication_ArrayWrapper
{
    public class ArrayWrapper
    {
        public int[] Array;

        public int[] Add(int[] addArray)
        {
            var length = this.Array.Length + addArray.Length;
            var superArray = new int[length]; 

            for (int i = 0; i < this.Array.Length; i++)
            {
                superArray[i] = this.Array[i];
            }

            for (int i = this.Array.Length; i < length; i++)
            {
                superArray[i] = addArray[i - this.Array.Length];
            }

            return superArray;
        }

        public int GetByIndex(int index)
        {
            if ((this.Array.Length < index) ||
                (index < 0))
            {
                return 0;
            }
            
            return this.Array[index];
        }

        public bool Contains(int number)
        {
            foreach (var numbers in this.Array)
            {
                if (numbers == number)
                {
                    return true;
                }
            }

            return false;
        }
    }
}