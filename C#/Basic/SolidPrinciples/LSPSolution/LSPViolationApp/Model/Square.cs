using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    internal class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {

        }
        public override void SetWidth(int width)
        {
            this._width = width;
        }
        public override void SetHeight(int height)
        {
            this._width = this._height = height;
        }
    }
}
