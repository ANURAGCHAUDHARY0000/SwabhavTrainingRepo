using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPViolationApp.Model;

namespace LSPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle:");
            ShouldNotChangeWidthIfHeightIsModified(new Rectangle(20, 30));
            Console.WriteLine("\nSquare:");
            ShouldNotChangeWidthIfHeightIsModified(new Square(5));
        }
        public static void ShouldNotChangeWidthIfHeightIsModified(Rectangle rectangle)
        {
            var before = rectangle.GetWidth();
            rectangle.SetHeight(rectangle.GetHeight() + 10);
            var after = rectangle.GetWidth();
            Console.WriteLine(before == after);
            Console.WriteLine(before);
            Console.WriteLine(after);
        }
    }
}
