using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToelib.Model;

namespace BoardTest
{
    [TestClass]
    public class BoardUnitTest
    {
        [TestMethod]
        public void ShouldBeAbleToCreateABoardWith9Cells()
        {
            Board b = new Board();
            Assert.AreEqual(9, b.GetCells.Length);
        }

        [TestMethod]

        public void ShouldCheckIfBoardIsEmpty()
        {
            var b = new Board();
            Assert.AreEqual(true, b.IsBoardEmpty());
        }

        [TestMethod]

        public void ShouldCheckIfBoardIsFull()
        {
            var b = new Board();
            Assert.AreEqual(false, b.IsBoardFull());
        }

        [TestMethod]
        public void ShouldBeAbleToMarkAtSpecifiedLocation()
        {
            Board b = new Board();
            Player ram = new Player("anu",MarkType.O);
            b.MarkCellAtPosition(2,MarkType.X);
            MarkType expectedMark = MarkType.O;
            Assert.AreEqual(expectedMark, ram.GetPlayerMark);
        }
    }
}
 