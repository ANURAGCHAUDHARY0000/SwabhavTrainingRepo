using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDefinedDelegatesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             CaseStudy1();
            //  CaseStudy2();
            //  CaseStudy3();
        }
        public static void CaseStudy1()
        {
            //Func point to a function that return a value
            Func<int, int, int> ptrTobigger = GetMeBiggerNo;
            Console.WriteLine("using ptr1 {0}",ptrTobigger(10,5));

            //Anonymous Function
            Func<int, int, int> ptrTobigger1 = delegate (int a, int b)
            {
                return a > b ? a : b;
            };

            Console.WriteLine("using ptr2 {0}", ptrTobigger1(10,20));

            //Lambda Expression 

            Func<int, int, int> ptrTobigger2 = (a,b) => a > b ? a : b;

            Console.WriteLine("using ptr3 {0}", ptrTobigger2(20, 30));


        }

        public static void CaseStudy2()
        {
            //Action point to a function that does not return a value

            Action<int> ptr1 = CubeEvenNumber;
            ptr1(4);

            //Anonymous Function

            Action<int> ptr2 = delegate (int no)
            {
                if (no % 2 == 0)
                    Console.WriteLine(no * no * no);
                else
                    Console.WriteLine("Can cube only even nos");
            };

            ptr2(2);

            //Lambda Expression 

            Action<int> ptr3 = ( no) =>
            {
                if (no % 2 == 0)
                    Console.WriteLine(no * no * no);
                else
                    Console.WriteLine("Can cube only even nos");
            };

            ptr3(6);

        }

        public static void CaseStudy3()
        {
            //Predicate points to a function which return bool value
            Predicate<int> ptr1 = IsEven;
            Console.WriteLine(ptr1(3));

            //Anonymous Function
            Predicate<int> ptr2 = delegate (int no)
            {
                return (no % 2 == 0);
            };

            Console.WriteLine(ptr2(4));

            // Lambda Function

            Predicate<int> ptr3 = (no) => no % 2 == 0;

            Console.WriteLine(ptr3(5));

        }

        //named function
        public static int GetMeBiggerNo(int a, int b)
        {
            return a > b ? a : b;
        }

        //named function
        public static void CubeEvenNumber(int no)
        {
            if(no % 2 == 0)
                Console.WriteLine(no*no*no);
            else
                Console.WriteLine("Can cube only even nos");
        }

        public static bool IsEven(int no)
        {
            return (no % 2 == 0);
        }
    }
}
