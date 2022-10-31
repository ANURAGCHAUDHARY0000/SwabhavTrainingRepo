using System;


namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool win = true;
            string response;
           

            while (win)
            {
                int randomNumber = random.Next(0, 100);
                Console.WriteLine("random number is :" + randomNumber);
                int guessNumber = 0;
                int tries = 1;
                int temp = 1;

                while (tries < 6)
                {
                 
                    Console.WriteLine("Enter number between 0 and 100: ");
                    guessNumber = Convert.ToInt32(Console.ReadLine());

                    if (guessNumber > randomNumber)
                    {

                        Console.WriteLine("It is too High!! ", guessNumber);
                        Console.WriteLine("you now have " + (5 - tries) + " chances left");
                        tries++;

                    }
                    else if (guessNumber < randomNumber)
                    {

                        Console.WriteLine("It is too Low!! ", guessNumber);
                        Console.WriteLine("you now have " + (5 - tries) + " chances left");
                        tries++;

                    }
                    else if (guessNumber == randomNumber)
                    {
                        Console.WriteLine("Congratulation It is correct You Won!", guessNumber);
                        temp = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This is an invalid number. Please try again");
                        Console.WriteLine("you now have " + (5 - tries) + " chances left");
                        continue;
                    }

                }
                if (temp == 1)
                {
                    Console.WriteLine("Sorry you lost the game!!");

                }
            
            if (tries == 1)
            {
                    Console.WriteLine("Your score is: 100");
            }
            if (tries == 2)
                {
                    Console.WriteLine("Your score is: 80");
                }
            if(tries == 3)
                {
                    Console.WriteLine("Your score is: 60");
                }
            if(temp == 4)
                {
                    Console.WriteLine("Your score is: 40");
                }
            if(temp == 5)
                {
                    Console.WriteLine("Your score is: 0");
                }
                if (tries == 5)
                {
                   Console.WriteLine("You have used your all tries");
                   Console.WriteLine("You lose the game");
                   Console.WriteLine("The Random number is:" + randomNumber);
                }

                Console.WriteLine("Would You Like To Play Again (yes/no):");
                Console.WriteLine("Enter your response:");
                response = Console.ReadLine();
                if (response == "yes")
                {
                    win = true;
                }
                else if(response == "no")
                {
                    win = false;
                }
            }
            
        }
    }
}