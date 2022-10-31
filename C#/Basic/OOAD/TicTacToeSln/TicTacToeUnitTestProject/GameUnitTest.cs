using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToelib.Model;

namespace BoardTest
{
    [TestClass]
    public class GameUnitTest
    {
        [TestMethod]
        public void Test_CheckCurrentPlayer()
        {
            Player[] players = new Player[2];
            players[0] = new Player("Anurag", MarkType.X);
            players[1] = new Player("Ram", MarkType.O);
            Game game = new Game(players, new Board(),new ResultAnalyzer(new Board()));
            game.Play(2);
            game.Play(5);
            Assert.AreEqual<string>(game.GetCurrentPlayer(), "Anurag");
        }


        [TestMethod]
        public void ShouldDisplayProgressAfterFirstPlay()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Player[] players  = { new Player("Anurag", MarkType.O), new Player("Ram", MarkType.X)};
            Game g = new Game(players, board, resultAnalyzer);
            g.Play(7);
            Assert.AreEqual(g.GetStatus() , ResultType.NO_RESULT);
        }

        [TestMethod]

        public void ShouldSwitchPlayer()
        {
            Player[] players = new Player[2];
            players[0] = new Player("Anurag", MarkType.X);
            players[1] = new Player("Ram", MarkType.O);
            Game game = new Game(players, new Board(), new ResultAnalyzer(new Board()));
            game.Play(2);//Anurag
            game.SwitchPlayer();
            Assert.AreEqual<string>(game.GetCurrentPlayer(), "Anurag");
        }




    }
}
