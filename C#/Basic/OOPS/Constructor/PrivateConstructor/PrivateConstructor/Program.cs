using System;
namespace PrivateConstructor
{
    class Example
    {
        public string fname;
        public string lname;
        private Example()
        {
         
        }
        public Example(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        public string GetFname()
        {
           return fname;
        }
        public string GetLname()
        {
            return lname;
        }
    }
    //class Example3 : Example
    //{

    //}
    // We can'nt inherit the class Example because of private accesifier.
    //we can'nt create instance of this class if it contains only private constructor.
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example("Ram","Kumar");
            Console.WriteLine(example.GetFname());
            Console.WriteLine(example.GetLname());

        }
    }
}
