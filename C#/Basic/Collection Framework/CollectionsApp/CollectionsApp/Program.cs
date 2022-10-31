using System;
using System.Collections;
using System.Collections.Generic;
using CollectionsApp.Model;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();
            CaseStudy2();
        }

        public static void CaseStudy1()
        {
            ArrayList myCart = new ArrayList();
            myCart.Add(new LineItem(5, 200, "books"));
            myCart.Add(new LineItem(10, 10, "pen"));
            myCart.Add(new LineItem(20, 5, "pencil"));
            myCart.Add(new LineItem(5, 20, "eraser"));
            myCart.Add(new LineItem(5, 15, "color"));
            myCart.Add("Krishna");

            foreach (Object item in myCart)
            {
                
                LineItem orderItem = (LineItem)item;
                Console.WriteLine(orderItem);
              
            }
        }

        public static void CaseStudy2()
        {
            List<LineItem> myCart = new List<LineItem>();
            myCart.Add(new LineItem(5, 200, "books"));
            myCart.Add(new LineItem(10, 10, "pen"));
            myCart.Add(new LineItem(20, 5, "pencil"));
            myCart.Add(new LineItem(5, 20, "eraser"));
            myCart.Add(new LineItem(5, 15, "color"));
          //  myCart.Add("Krishna");

            foreach(LineItem item in myCart)
            {
                Console.WriteLine( item);
            }

        }
    }
}
