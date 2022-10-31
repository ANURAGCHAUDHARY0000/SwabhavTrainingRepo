using System;
using OddAndEven.Model;

namespace OddAndEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindingEvenOdd findingEvenOdd = new FindingEvenOdd();
            findingEvenOdd.Range = 20;
            int[] EvenArray = findingEvenOdd.GenerateEvenNumber();
            for(int i = 0; i < EvenArray.Length; i++)
            {
                Console.Write(EvenArray[i] + " ");
            }
            
            int[] OddArray = findingEvenOdd.GenerateOddNumber();
            for (int i = 0; i < OddArray.Length; i++)
            {
                Console.Write(OddArray[i] + " ");
            }
        }
    }
}
