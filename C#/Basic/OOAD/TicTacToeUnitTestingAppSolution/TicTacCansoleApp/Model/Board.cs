using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeConsoleApp.CustomException;


namespace TicTacToeConsoleApp.Model
{
    public class Board
    {
        public Cell[] _cells = new Cell[9];

        public Board()
        {
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

        public void MarkCellAtPosition(int location, Player player)
        {
            _cells[location].SetMark(player.GetMark);
        }
        public Cell[] GetCells
        {
            get
            {
                return _cells;
            }
        }
    }
}
