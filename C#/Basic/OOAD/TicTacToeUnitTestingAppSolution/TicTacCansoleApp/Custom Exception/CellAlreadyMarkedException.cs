﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp.CustomException
{
    public class CellAlreadyMarkedException : Exception
    {
        String message;

        public CellAlreadyMarkedException(string message) : base(message)
        {
            this.message = message;
        }

        public override string Message
        {
            get { return message; }
        }
    }
}
