using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int cpuScore = 0;
            bool running = true;
            while (running) {

            Console.WriteLine("Play (R)ock (P)aper (S)cissors");
            ConsoleKeyInfo userInput = System.Console.ReadKey();
            Console.Clear();
            if (userInput.Key == ConsoleKey.R)
        {
            Random rnd = new Random();
            int decider = rnd.Next(1,6);
            if( decider <= 3){
                System.Console.WriteLine("The Computer picked Paper, you lose");
                cpuScore = cpuScore+1;
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);
            }
            else if( decider == 4){
                System.Console.WriteLine("The Computer Picked Rock, you tie");
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);

            }
            else if( decider == 5){
                System.Console.WriteLine("The Computer Picked Scissors, you win");
                playerScore = playerScore + 1;
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);

            }

        }
        else if (userInput.Key == ConsoleKey.P)
        {
            Random rnd = new Random();
            int decider = rnd.Next(1,6);
            if( decider <= 3){
                System.Console.WriteLine("The Computer picked Scissors, you lose");
                cpuScore++;
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);
            }
            else if( decider == 4){
                System.Console.WriteLine("The Computer Picked Paper, you tie");
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);
            }
            else if( decider == 5){
                System.Console.WriteLine("The Computer Picked Rock, you win");
                playerScore++;
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);
            }

        }
        else if (userInput.Key == ConsoleKey.S)
        {
            Random rnd = new Random();
            int decider = rnd.Next(1,6);
            if( decider <= 3){
                System.Console.WriteLine("The Computer picked Rock, you lose");
                cpuScore++;
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);
            }
            else if( decider == 4){
                System.Console.WriteLine("The Computer Picked Scissors, you tie");
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);
            }
            else if( decider == 5){
                System.Console.WriteLine("The Computer Picked Paper, you win");
                playerScore++;
                System.Console.WriteLine("CPU Score: "+ cpuScore+" Your Score: "+ playerScore);
            }

        }
        else
        {
          System.Console.WriteLine("invalid input");
        }

      }


        }
    }
}
