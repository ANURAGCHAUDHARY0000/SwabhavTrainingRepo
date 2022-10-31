using System;

namespace PigDiceGame.Model
{
    internal class PlayGame
    {
        private int _turn;
        private int _turnScore, _totalScore;

        public PlayGame()
        {
            _turn = 1;
            _turnScore = 0;
            _totalScore = 0;
        }
        public void StartGame()
        {
            while (true)
            {
                Console.WriteLine("Turn: " + _turn);
                _turnScore = RollDie();
             //   _totalScore = _totalScore + _turnScore ;
               
                if (_totalScore >= 20)
                {
                    Console.WriteLine("Turn score: " + _turnScore);
                    Console.WriteLine("Total score: " + _totalScore);
                    Console.WriteLine("Total turn: " + _turn);
                    Console.WriteLine("You won!!");
                }
                else
                {
                    Console.WriteLine("Turn score: " + _turnScore);
                    Console.WriteLine("Total score: " + _totalScore);
                    _turn++;
                }
            }
           
        }
        public int RollDie()
        {

            Random random = new Random();
            int die;
            while (CheckRollOrHold())
            {
                die = random.Next(1, 7);
                Console.WriteLine("Die: " + die);
                _totalScore = _totalScore + die;
                if (die == 1)
                {
                    Console.WriteLine("Turn Over.No score.");
                    _turnScore = 0;
                    break;
                }
                _turnScore += die;
                if (_turnScore + _totalScore >= 20)
                    return _turnScore;
            }
            return _turnScore;
        }
        public bool CheckRollOrHold()
        {
            Console.WriteLine("Roll or hold?(r/h)");
            char choice = Console.ReadLine()[0];
            if (choice == 'r' || choice == 'R')
                return true;
            if (choice == 'h' || choice == 'H')
                return false;
            return false;

        }


    }
}





