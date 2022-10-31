using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWinFormsApp.CustomException;


namespace TicTacToeWinFormsApp.Model
{
    internal class Board
    {
        private Cell[] _cells;
       
        public Board()
        {
           
            _cells = new Cell[9];
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new Cell();
            }
                                
        }
      
        public bool IsBoardEmpty()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (_cells[i].GetMark == MarkType.EMPTY)
                    return true;
            }
            return false;
        }
        public bool IsBoardFull()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (_cells[i].GetMark == MarkType.EMPTY)
                    return false;
                else
                    continue;
            }
            return true;
        }

        public void MarkCellAtPosition(int location, MarkType mark)
        {
            _cells[location].SetMark(mark);
        }


        public Cell[] GetCells
        {
            get
            {
                return _cells;
            }
        }
        
        
        public void ResetBoard()
        {
            _cells = new Cell[9];
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new Cell();
            }
        }
    }
}
