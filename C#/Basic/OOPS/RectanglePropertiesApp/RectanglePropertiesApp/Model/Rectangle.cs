using System;
namespace RectanglePropertiesApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        public int Width
        {
            set
            {
                CheckLimit(value);
                _width = value;
            }
            
            get
            {
                return _width;
            }
        }
        public int Height
        {
            set
            {
                CheckLimit(value);
                _height = value;
            }
            get { return _height; }
        }
        public int CalculateArea()
        {
            int area = _width * _height;
            return area;
        }
        public int CalculatePerimeter()
        {
            int perimeter = 2 * (_width * _height);
            return perimeter;
        }

        public int CheckLimit(int side)
        {
            if (side > 1 && side < 101)
                return side;
            if (side > 100)
                return 100;
            return 1;
        }
    }
}


