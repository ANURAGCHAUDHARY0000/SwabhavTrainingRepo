using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeApp.CustomException;

namespace TicTacToeApp.Model
{
    internal class Game
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
            if (location < 0 || location > 8)
            {
                throw new IndexOutOfBoundException("Please Enter location between (0 -8)");
            }
            if (!_board.GetCells[location].CheckDuplicateLocation())
            {
                _board.MarkCellAtPosition(location, _currentPlayer.GetPlayerMark);
                GetCurrentPlayer();
                SwitchPlayer();
            }

            else
                throw new CellAlreadyMarkedException("Cell is already Marked");
            _analyzer.Analyze();
            _status = _analyzer.Analyze();

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


        public string GetCurrentPlayer()
        {
           
                return _currentPlayer.GetPlayerName;
            
        }

      
        public Board GetBoard
        {
            get
            {
                return _analyzer.GetBoard;
            }
        }
    }
}
