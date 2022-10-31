using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeConsoleApp.CustomException;

namespace TicTacToeConsoleApp.Model
{
    public class Game
    {
        private Player[] _player;
        Board _board;
        private ResultAnalyzer _analyzer;
        private ResultType _status;
        private Player _currentPlayer;
       
        public Game(Player[] player,Board board ,ResultAnalyzer analyzer)
        {
            _player = player;
            _analyzer = analyzer;
            _board = board;
            _currentPlayer = _player[0];
            this._status = _analyzer.Analyze();
        }


        public void SwitchPlayer()
        {
            if (_currentPlayer == _player[0])
                _currentPlayer = _player[1];
            else if (_currentPlayer == _player[1])
                _currentPlayer = _player[0];
        }

        public void Play(int location)
        {
            if(location > 8)
            {
                throw new IndexOutOfBoundException("Please Enter location between (0 -8)");
            }
            if (!_board.GetCells[location].CheckDuplicateLocation())
            {
                _board.MarkCellAtPosition(location, _currentPlayer);
                SwitchPlayer();
            }

            else
            throw new CellAlreadyMarkedException("Cell is already Marked");
            _status = _analyzer.Analyze();
           // _status = _analyzer.Analyze();

        }

        public ResultType GetStatus()
        {
            
                _status = GetAnalyzer.Analyze();
                return _status;
            
        }
       
        public ResultAnalyzer GetAnalyzer
        {
            get
            {
                return _analyzer;
            }
        }


        public string GetCurrentPlayer
        {
            get
            {
                return _currentPlayer.GetName;
            }
        }

        public void PrintBoard()
        {

            Console.WriteLine(_board.GetCells[0].GetMark +
                "|" + _board.GetCells[1].GetMark +
                "|" + _board.GetCells[2].GetMark);
            Console.WriteLine("-------------------");
            Console.WriteLine(_board.GetCells[3].GetMark +
                "|" + _board.GetCells[4].GetMark +
                "|" + _board.GetCells[5].GetMark);
            Console.WriteLine("-------------------");
            Console.WriteLine(_board.GetCells[6].GetMark +
                "|" + _board.GetCells[7].GetMark +
                "|" + _board.GetCells[8].GetMark);
        }

    }
}

