using System;

namespace ConsoleApplication_Lottery
{
    public class LotteryIndex
    {
        private readonly int[] _array = new int[6];
        private readonly int[] _randomArray = new int[6];


        public bool this[int index] => _array[index] == _randomArray[index];

        public bool Validate(string line, out int number)
        {
            var tryNumber = 0;
            if (int.TryParse(line, out tryNumber))
            {
                number = tryNumber;
                return (tryNumber > 0) && (tryNumber < 10);
            }
            number = 0;
            return false;
        }

        public void GetNumbers()
        {
            var rnd = new Random();

            Console.WriteLine("Input 6 numbers between 1 and 9");
            for (var i = 0; i < 6; i++)
            {
                var numberIsValid = false;

                do
                {
                    var number = 0;
                    var line = Console.ReadLine();
                    if (Validate(line, out number))
                    {
                        _array[i] = number;
                        numberIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Input valid number.");
                    }      
                } while (!numberIsValid);
            }

            for (var i = 0; i < 6; i++)
            {
                _randomArray[i] = rnd.Next(0, 10);
            }
        }
    }
}