using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToelib.Model;

namespace BoardTest
{
    [TestClass]
    public class CellUnitTest
    {
        [TestMethod]
        public void CellShouldBeEmptyOnceCreated()
        {
            Cell c = new Cell();
            Assert.AreEqual(true, c.IsEmpty());
        }

        [TestMethod]

        public void CellShouldBeAbleToMarkNought()
        {
            Cell c = new Cell();
            c.SetMark(MarkType.O);
            MarkType expectedMark = MarkType.O;
            Assert.AreEqual(expectedMark, c.GetMark);
        }

        [TestMethod]

        public void CellShouldBeAbleToMarkCross()
        {
            Cell c = new Cell();
            c.SetMark(MarkType.X);
            MarkType expectedMark = MarkType.X;
            Assert.AreEqual(expectedMark, c.GetMark);
        }

        [TestMethod]

        public void CellShouldNotMarkedAgain()
        {
            Cell c = new Cell();
            Assert.AreEqual(false, c.CheckDuplicateLocation());
        }
    }
}
