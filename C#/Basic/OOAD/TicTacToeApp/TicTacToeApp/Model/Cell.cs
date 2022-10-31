using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeApp.CustomException;

namespace TicTacToeApp.Model
{
    internal class Cell
    {
        private MarkType _mark;

        public Cell()
        {
            _mark = MarkType.EMPTY;
        }

        public bool IsEmpty()
        {

            if (_mark.Equals(MarkType.EMPTY))
                return true;
            else
                return false;
        }


        public void SetMark(MarkType mark)
        {
            this._mark = mark;
        }

        public MarkType GetMark
        {
            get
            {
                return _mark;
            }
        }

        public bool CheckDuplicateLocation()
        {
            if (!IsEmpty())
            {
                return true;
            }
            return false;
        }

    }
}
