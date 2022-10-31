using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp.Model
{
    public class ResultAnalyzer
    {
        private Board _board;
        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public ResultType Analyze()
        {

            if (CheckRow().Equals(ResultType.WIN) || CheckColumn().Equals(ResultType.WIN)
                || CheckDiagonal().Equals(ResultType.WIN))
                return ResultType.WIN;
            else if (_board.IsBoardFull())
                return ResultType.DRAW;
            return ResultType.PROGRESS;
        }

        private ResultType CheckRow()
        {
            if (ChechEveryCondition(1, 2, 3))
                return ResultType.WIN;
            else if (ChechEveryCondition(4, 5, 6))
                return ResultType.WIN;
            else if (ChechEveryCondition(7, 8, 9))
                return ResultType.WIN;
            return ResultType.PROGRESS;
        }


        private ResultType CheckColumn()
        {
            if (ChechEveryCondition(1, 4, 7))
                return ResultType.WIN;
            else if (ChechEveryCondition(2, 5, 8))
                return ResultType.WIN;
            else if (ChechEveryCondition(3, 6, 9))
                return ResultType.WIN;
            return ResultType.PROGRESS;
        }

        private ResultType CheckDiagonal()
        {
            if (ChechEveryCondition(1, 5, 9))
                return ResultType.WIN;
            else if (ChechEveryCondition(3, 5, 7))
                return ResultType.WIN;
            return ResultType.PROGRESS;
        }
        private bool ChechEveryCondition(int i, int j, int k)
        {

            if (_board.GetCells[i - 1].GetMark == _board.GetCells[j - 1].GetMark &&
                _board.GetCells[j - 1].GetMark == _board.GetCells[k - 1].GetMark &&
                _board.GetCells[i - 1].GetMark != MarkType.EMPTY)
                return true;
            return false;
        }

        public Board GetBoard
        {
            get
            {
                return _board;
            }
        }

    }
}
