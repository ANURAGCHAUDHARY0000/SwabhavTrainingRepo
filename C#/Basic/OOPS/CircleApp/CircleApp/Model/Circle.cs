using System;

namespace CircleApp.Model
{
    internal class Circle
    {
        public double radius;
        public string color;
        public double Area()
        {
            double area = 3.14 * radius  * radius;
            return area;
        }
        public double Perimeter()
        {
             double perimeter = 2 * 3.14 * radius;
            return perimeter;
        }
    }
}
