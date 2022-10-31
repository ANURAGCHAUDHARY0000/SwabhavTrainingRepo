using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeConsoleApp.Model;

namespace BoardTest
{
    [TestClass]
    public class ResultAnalyserUnitTest1
    {
        ResultAnalyzer analyzer = new ResultAnalyzer(new Board());
       
        [TestMethod]
        public void Test_CheckRowWin()
        {
            analyzer.GetBoard.MarkCellAtPosition(0, new Player("Ram",MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(1, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(2, new Player("Ram", MarkType.O));
            Assert.AreEqual<ResultType>(analyzer.Analyze(), ResultType.WIN);
        }

        [TestMethod]
        public void Test_CheckColumnWin()
        {
            analyzer.GetBoard.MarkCellAtPosition(1, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(4, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(7, new Player("Ram", MarkType.O));
            Assert.AreEqual<ResultType>(analyzer.Analyze(), ResultType.PROGRESS);
        }

        [TestMethod]
        public void Test_CheckDiagonalWin()
        {
            analyzer.GetBoard.MarkCellAtPosition(0, new Player("Anu", MarkType.X)); 
            analyzer.GetBoard.MarkCellAtPosition(1, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(2, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(3, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(4, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(5, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(6, new Player("Anu", MarkType.X));
            Assert.AreEqual<ResultType>(analyzer.Analyze(), ResultType.WIN);
        }

        [TestMethod]
        public void Test_CheckDorwCondition()
        {
           
            analyzer.GetBoard.MarkCellAtPosition(0, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(1, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(2, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(3, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(4, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(5, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(6, new Player("Ram", MarkType.O));
            analyzer.GetBoard.MarkCellAtPosition(7, new Player("Anu", MarkType.X));
            analyzer.GetBoard.MarkCellAtPosition(8, new Player("Ram", MarkType.O));
            Assert.AreEqual<ResultType>(analyzer.Analyze(), ResultType.DRAW);
        }
    }
}
