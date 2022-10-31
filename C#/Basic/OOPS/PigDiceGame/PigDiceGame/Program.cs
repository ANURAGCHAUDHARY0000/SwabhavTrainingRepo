using System;
using PigDiceGame.Model;
namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayGame playGame = new PlayGame();
            playGame.StartGame();
        }
    }
}
