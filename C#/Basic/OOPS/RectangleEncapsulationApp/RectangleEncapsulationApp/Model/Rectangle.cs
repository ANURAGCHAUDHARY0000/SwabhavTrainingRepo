using System;
namespace RectangleEncapsulationApp.Model
{
    internal class Rectangle
    {
      private int _width;
      private int _height;
      private string _color;
      private string _borderColor;

     public void SetWidth(int Width)
     {
            _width = CheckLimit(Width);
        }

       public void SetHeight(int height)
        {
            _height = CheckLimit(height);
        }

        public void SetColor(string color)
        {
            _color = CheckColor(color);
        }
        public void SetBorderColor(string bordercolor)
        {
            _borderColor = CheckColor(bordercolor);
        }

        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;
        }
        public string GetColor()
        {
            return _color;
        }
        public string GetBorderColor()
        {
            return _borderColor;
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

        private string CheckColor(string color)
        {
            if (color == "red" || color == "green" || color == "blue" || color == "yellow") 
            {
                return color;
            }
            else
            {
                return  "red";
            }
        }
    }
}
