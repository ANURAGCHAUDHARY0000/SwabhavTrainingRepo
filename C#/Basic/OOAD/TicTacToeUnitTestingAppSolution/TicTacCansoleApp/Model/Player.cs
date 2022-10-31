using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp.Model
{
    public class Player
    {
        private string _name;
        private MarkType _mark;

        public Player(string name, MarkType mark)
        {
            _name = name;
            _mark = mark;
        }

        public string GetName
        {
            get
            {
                return _name;
            }
        }
        public MarkType GetMark
        {
            get
            {
                return _mark;
            }
        }
    }
}
