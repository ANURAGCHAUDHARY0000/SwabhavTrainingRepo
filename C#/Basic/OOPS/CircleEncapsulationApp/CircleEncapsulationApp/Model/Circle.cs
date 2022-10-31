using System;

namespace CircleEncapsulationApp.Model
{
    internal class Circle
    {
        private float _radius;
        private string _borderStyle;

        public void SetRadius(float radius)
        {
            if(radius < 1)
            {
                _radius = 1;
            }
            else if(radius > 10)
            {
                _radius = 10;
            }
            else 
            { 
                _radius = radius;
            }
        }

        public void SetBorderStyle(string borderStyle)
        {
                if (borderStyle.ToUpper() == ("single").ToUpper() || borderStyle.ToUpper() == ("double").ToUpper() || borderStyle.ToUpper() == ("dotted").ToUpper())
                {
                    _borderStyle = borderStyle;
                }
                else
                    _borderStyle = "single";
        }

        public float CalculateArea()
        {
            float area = 3.14f * _radius * _radius;
            return area;
        }
        public float CalculatePerimeter()
        {
            float perimeter = 2 * 3.14f * _radius;
            return perimeter;
        }
        public float GetRadius()
        {
            return _radius;
        }
        public string GetBorderStyle()
        {
            return _borderStyle;
        }

       
    }
}
