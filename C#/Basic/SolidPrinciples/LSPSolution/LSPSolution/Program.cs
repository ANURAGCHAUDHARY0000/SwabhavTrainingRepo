using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolution.Model;

namespace LSPSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle:");
            ShouldNotChangeWidthIfHeightIsModified(new Rectangle(20, 30));
           
        }
        public static void ShouldNotChangeWidthIfHeightIsModified(Rectangle rectangle)
        {
            var before = rectangle.Width;
            rectangle.SetHeight(rectangle.Height + 10);
            var after = rectangle.Width;
            Console.WriteLine(before == after);
            Console.WriteLine(before);
            Console.WriteLine(after);
        }
    }
}
