using System;

namespace Rock_Paper_Scissors
{
    class Rock_Paper_Scissors
    {
        static void Main(string[] args)
        {
            //Add in a best out of 3 turns wins and a best out of 3 rounds wins the game, a total of 9 rounds//
            Console.WriteLine("Do you want to play a game? Choose Rock, Paper or Scissors");
            string PlayerChoice = Console.ReadLine();

            Random Random = new Random();
            int CPUChoice = Random.Next(3);

                if (CPUChoice == 1)
                {
                    if (PlayerChoice == "Rock")
                    {
                        Console.WriteLine("You both chose Rock, it is a tie.");
                    }
                    else if (PlayerChoice == "Paper")
                    {
                        Console.WriteLine("You both chose Paper, it is a tie.");
                    }
                    else if (PlayerChoice == "Scissors")
                    {
                        Console.WriteLine("You both chose Scissors, it is a tie.");
                    }
                    else
                    {
                        Console.WriteLine("Please chose either Rock, Paper or Scissors");
                    }
                }
                else if (CPUChoice == 2)
                {
                    if (PlayerChoice == "Rock")
                    {
                        Console.WriteLine("The CPU chose Paper, you lose this round");
                    }
                    else if (PlayerChoice == "Paper")
                    {
                        Console.WriteLine("The CPU chose Scissors, you lose this round");
                    }
                    else if (PlayerChoice == "Scissors")
                    {
                        Console.WriteLine("The CPU chose Rock, you lose this round");
                    }
                    else
                    {
                        Console.WriteLine("Please chose either Rock, Paper or Scissors");
                    }
                }
                else if (CPUChoice == 3)
                {
                    if (PlayerChoice == "Rock")
                    {
                        Console.WriteLine("The CPU chose Scissors, you win this round!");
                    }
                    else if (PlayerChoice == "Paper")
                    {
                        Console.WriteLine("The CPU chose Rock, you win this round!");
                    }
                    else if (PlayerChoice == "Scissors")
                    {
                        Console.WriteLine("The CPU chose Paper, you win this round!");
                    }
                    else
                    {
                        Console.WriteLine("Please chose either Rock, Paper or Scissors");
                    }
                
                }
            








        }
    }
}
