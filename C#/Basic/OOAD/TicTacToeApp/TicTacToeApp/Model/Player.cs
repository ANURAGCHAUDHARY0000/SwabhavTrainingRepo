using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApp.Model
{
    internal class Player
    {
        private string _name;
        private MarkType _mark;

        public Player() { }

        public Player(string name, MarkType mark)
        {
            _name = name;
            _mark = mark;
        }

        public string GetPlayerName
        {
            get
            {
                return _name;
            }
        }
        public MarkType GetPlayerMark
        {
            get
            {
                return _mark;
            }
        }
    }
}
