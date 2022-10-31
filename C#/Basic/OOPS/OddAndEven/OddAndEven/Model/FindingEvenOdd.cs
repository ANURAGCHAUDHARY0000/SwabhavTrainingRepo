using System;

namespace OddAndEven.Model
{
    internal class FindingEvenOdd
    {
        private int _range;

        public int Range
        {
            set{
                _range = value;
            }
            
        }

        public int [] GenerateEvenNumber()
        {
            Console.WriteLine("Even Numbers from 1 to 100");
            int[] result = new int[_range];
            int index = 0;
            for (int a = 1; a <= _range; a++)
            {
                if (a % 2 == 0)
                {
                    result[index++] = a;
                }
            }
            return result;
        }

        public int [] GenerateOddNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Odd Numbers from 1 to 100");
            int[] result1 = new int[_range];
            int index = 0;
            for (int b = 1; b <= _range; b++)
            {
                if (b % 2 != 0)
                {
                    result1[index++] = b;   
                }
            }
            return result1;
        }
    }
}
