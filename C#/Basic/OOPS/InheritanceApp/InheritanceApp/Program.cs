using System;
using InheritanceApp.Model;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    CaseStudy1();
        //    CaseStudy2();
        //    CaseStudy3();
              CaseStudy4();
              CaseStudy5();
        }

        public static void CaseStudy1()
        {
            Man x = new Man();
            x.Read();
            x.Play();
        }

        public static void CaseStudy2()
        {
            Boy  y = new Boy();
            y.Read();
            y.Play();
            y.Eat();
        }

        public static void CaseStudy3()
        {
            Man x = new Boy();
            x.Read();
            x.Play();
          //  x.Eat();
        }

        public static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());

        }

        public static void AtThePark(Man x)
        {
            Console.WriteLine("At The Park");
            x.Play();
        }

        public static void CaseStudy5()
        {
            object x;  //highest level of polymorphism
            x = 100;
            Console.WriteLine(x.GetType());
            x = "Hello";
            Console.WriteLine(x.GetType());
            x = 10 > 5;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
           // x.Play(); // we can'nt call these method because of x is object type which is parent
           //x.Read();// we can'nt call child method from parent method
           Man m =  (Man)(x); // typecasting of object

            m.Play();
            m.Read();
            
        }
    }
}
