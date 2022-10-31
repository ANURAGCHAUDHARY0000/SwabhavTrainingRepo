using System;


namespace PigDice.Model
{
    internal class Game
    {
        private int score = 0;
        private static int turn = 1;

		public void GameStart()
		{

			while (true)
			{
				int temp = DiceRoll();
				this.score += temp;
                Console.WriteLine("------------------------------------------");
				Console.WriteLine("your turn score is " + temp);
				Console.WriteLine("your total score is " + this.score);
				Console.WriteLine("your total number of turn " + turn++);
				Console.WriteLine("------------------------------------------");
				Console.WriteLine();
				if (this.score >= 20)
					break;
			}
			Console.WriteLine("it take " + turn + " attempts you to complete game and your score is " + score);
		}

		public int DiceRoll()
		{
			int temp = 0;
			while (true)
			{
				Console.WriteLine("TURN " + turn);
				Random rand = new Random();
				int dice = rand.Next(1, 7);
				Console.WriteLine("Roll or Hold? (r/h)");
				char choice = Console.ReadLine()[0];
				if (choice == 'h' || choice == 'H')
					return temp;
				Console.WriteLine("your dice score " + dice);
				temp += dice;
				if (dice == 1)
					return 0;
				if (this.score + temp >= 20)
					return temp;
				if (choice == 'r' || choice == 'R')
					continue;
				return temp;
			}
		}


	}
}
