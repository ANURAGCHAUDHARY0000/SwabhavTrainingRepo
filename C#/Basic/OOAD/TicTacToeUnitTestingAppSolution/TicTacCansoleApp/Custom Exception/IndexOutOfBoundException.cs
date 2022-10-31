using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp.CustomException
{
    public class IndexOutOfBoundException : Exception
    {
        string message;
        public IndexOutOfBoundException(string message) : base(message)
        {
            this.message = message;

        }
      
        public override string Message
        {
            get { return message; }
        }
    }
}
