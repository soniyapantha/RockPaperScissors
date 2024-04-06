using System;
using System.Runtime.InteropServices;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU = ""; 
            int randomInt;
            
            bool playAgain = true;
            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

             
            Console.Write("Choose between Rock, Paper, and Scissors: ");
            inputPlayer = Console.ReadLine();

            inputPlayer = inputPlayer.ToUpper();
            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);
            switch (randomInt)
            {
                case 1:
                    inputCPU = "Rock";
                   
                    break;
                case 2:
                    inputCPU = "Paper";
                 
                    break;
                case 3:
                    inputCPU = "Scissors";
                 
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }

            
            Console.WriteLine($"Your choice: {inputPlayer}");
            Console.WriteLine($"Computer's choice: {inputCPU}");

            
            if (inputPlayer == inputCPU)
            {
                Console.WriteLine("Draw!!");
            }
            else if (
                (inputPlayer == "Rock" && inputCPU == "Scissors") ||
                (inputPlayer == "Paper" && inputCPU == "Rock") ||
                (inputPlayer == "Scissors" && inputCPU == "Paper")
            )

            {
                Console.WriteLine("You win!!");
                scorePlayer++;
            }
            else
            {
                Console.WriteLine("Computer wins!!");
                scoreCPU++;
            }

            
            Console.WriteLine($"Your Score: {scorePlayer}");
            Console.WriteLine($"Computer's Score: {scoreCPU}");

            if (scorePlayer == 3)
            {
                Console.WriteLine("player won");
            }
            else if (scoreCPU == 3)
            {
                Console.WriteLine("cpu won");
            }
            else
            {

            }
            Console.WriteLine("Do you want to play again?(y/n)");
                    Console.WriteLine("just checking for lerning branch and merge in github?(y/n)");
                    string loop=Console.ReadLine();
            if(loop=="y")
            {
                playAgain = true;
            }
            else if(loop=="n")
            {
                playAgain =false;
            }
            else
            {

            }
          
          
            Console.ReadLine();
                }
            }
        }
    }
}
