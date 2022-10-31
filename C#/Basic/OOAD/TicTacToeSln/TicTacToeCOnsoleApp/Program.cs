using System;
using TicTacToelib.Model;
using TicTacToelib.CustomException;


namespace TicTacToeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[2];
            players[0] = new Player("Anurag", MarkType.X);
            players[1] = new Player("Krishna", MarkType.O);
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(players, board, resultAnalyzer);
            Console.WriteLine("Welcome to Tic Tac Toe Game");

            while (!game.GetStatus().Equals(ResultType.WIN) && !game.GetStatus().Equals(ResultType.DRAW))
            {
                GameBoard(game);
                try
                {
                    Console.WriteLine(game.GetCurrentPlayer() + " Enter your location:");
                    var input = int.Parse(Console.ReadLine());
                    game.Play(input);
                }
                catch (CellAlreadyMarkedException ex)
                { Console.WriteLine(ex.Message); }

                catch (IndexOutOfBoundException ex)
                { Console.WriteLine(ex.Message); }

                game.GetStatus();

            }
            game.SwitchPlayer();
            GameBoard(game);
            if (game.GetStatus().Equals(ResultType.WIN))
                Console.WriteLine(game.GetCurrentPlayer() + " wins the game");
            else if (game.GetStatus().Equals(ResultType.DRAW))
                Console.WriteLine("Match is Draw");
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
        public static void GameBoard(Game game)
        {

            Console.WriteLine(game.GetBoard.GetCells[0].GetMark +
                "|" + game.GetBoard.GetCells[1].GetMark +
                "|" + game.GetBoard.GetCells[2].GetMark);
            Console.WriteLine("-------------------");
            Console.WriteLine(game.GetBoard.GetCells[3].GetMark +
                "|" + game.GetBoard.GetCells[4].GetMark +
                "|" + game.GetBoard.GetCells[5].GetMark);
            Console.WriteLine("-------------------");
            Console.WriteLine(game.GetBoard.GetCells[6].GetMark +
                "|" + game.GetBoard.GetCells[7].GetMark +
                "|" + game.GetBoard.GetCells[8].GetMark);

        }
    }
}


