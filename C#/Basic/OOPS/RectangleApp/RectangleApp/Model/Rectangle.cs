using System;

namespace RectangleApp.Model
{
    internal class Rectangle
    {
        public int width;
        public int height;
        public string color;
        public int CalculateArea()
        {
            int area = width * height;
            return area;
        }


    }


}
