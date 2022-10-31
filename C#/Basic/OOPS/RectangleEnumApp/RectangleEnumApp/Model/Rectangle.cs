using System;

namespace RectangleEnumApp.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private BorderStyleOptions _borderStyle;

        public Rectangle(int width, int height, BorderStyleOptions borderStyle)
        {
            _width = width;
            _height = height;
            _borderStyle = borderStyle;
        }

        public Rectangle(int width,int height) : this (width,height,BorderStyleOptions.Single)
        { }

        public int CalculateArea()
            { return _width * _height; }

        public int Width
         { get { return _width; } }

        public int Height { get { return _height; } }

        public BorderStyleOptions BorderStyle
        {
            set { _borderStyle = value; }
            get { return _borderStyle; }
        }
    }
}
