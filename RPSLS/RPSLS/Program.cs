using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> choices = new List<string>() { "rock", "paper", "scissors", "lizard", "spock"};
            displayRules();
            int scoreToWin = (int)(GetBestOf() / 2.0 + .5);
            Console.Clear();
            Console.WriteLine("What is your name Player 1?");
            Human player1 = new Human(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Do you have another player to play against? 'yes' or 'no'");
            string userInputString = Console.ReadLine().ToLower();
            Console.Clear();
            while (!validateYesNo(userInputString))
            {
                Console.WriteLine("Invalid Answer!");
                Console.WriteLine("Do you have another player to play against? 'yes' or 'no'");
                userInputString = Console.ReadLine().ToLower();
                Console.Clear();
            }
            if (userInputString.Equals("no"))
            {
                CPU player2 = new CPU();
                while (player1.GetScore() < scoreToWin && player2.GetScore() < scoreToWin)
                {
                    player1.SetChoice(AskForChoice(choices));
                    player2.MakeChoice(choices);
                    if(!CheckIfTie(player1, player2))
                    {
                        GetWinner(player1, player2).IncrementScore();
                    }
                    else
                    {
                        Console.WriteLine("Wow its a Tie!");
                    }
                    Console.WriteLine("\n Please press Enter to Continue!");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (player1.GetScore() == scoreToWin)
                {
                    Console.WriteLine(player1.GetName() + " won the game!");
                }
                else
                {
                    Console.WriteLine("The CPU won the game!");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is your name Player 2?");
                Human player2 = new Human(Console.ReadLine());
                Console.Clear();
                while (player1.GetScore() < scoreToWin && player2.GetScore() < scoreToWin)
                {
                    Console.WriteLine("\n" + player1.GetName() + ":");
                    player1.SetChoice(AskForChoice(choices));
                    Console.Clear();
                    Console.WriteLine("\n" + player2.GetName() +":");
                    player2.SetChoice(AskForChoice(choices));
                    Console.Clear();
                    if (!CheckIfTie(player1, player2))
                    {
                        GetWinner(player1, player2).IncrementScore();
                    }
                    else
                    {
                        Console.WriteLine("Wow its a Tie!");
                    }
                    Console.WriteLine("\n Please press Enter to Continue!");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (player1.GetScore() == scoreToWin)
                {
                    Console.WriteLine(player1.GetName() + " won the game!");
                }
                else
                {
                    Console.WriteLine(player2.GetName() + " won the game!");
                }
                Console.ReadLine();
            }
        }
        public static string AskForChoice(List<string> choices)
        {
            Console.WriteLine("Please choose : 'rock' , 'paper' , 'scissors' , 'lizard' , or 'spock'");
            string choice = Console.ReadLine().ToLower();
            Console.Clear();
            if (validateChoice(choice, choices))
            {
                return choice;
            }
            Console.WriteLine("Invalid Entry!");
            return AskForChoice(choices);
        }
        public static bool validateChoice(string userInput, List<string> choices)
        {
            foreach (string choice in choices)
            {
                if (userInput.Equals(choice))
                {
                    return true;
                }
            }
            return false;
        }
        public static int GetBestOf()
        {
            Console.WriteLine("How many games would you like to play best of? Ex. Best of 7 - First to 4 wins");
            string userInput = Console.ReadLine();
            int bestOf;
            if (int.TryParse(userInput, out bestOf))
            {
                if (validateOdd(bestOf))
                {
                    return bestOf;
                }
            }
            Console.Clear();
            Console.WriteLine("Invalid Entry!");
            return GetBestOf();
        }
        public static bool validateOdd(int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public static bool validateYesNo(string userInput)
        {
            if(userInput.Equals("yes") || userInput.Equals("no"))
            {
                return true;
            }
            return false;
        }
        public static bool CheckIfTie(Player player1, Player player2)
        {
            if(player1.GetChoice().Equals(player2.GetChoice()))
            {
                return true;
            }
            return false;
        }
        public static Player GetWinner(Player player1, Player player2)
        {
            if (player1.GetChoice().Equals("rock"))
            {
                if (player2.GetChoice().Equals("paper"))
                {
                    Console.WriteLine("Paper covers Rock!");
                    return player2;
                }
                else if (player2.GetChoice().Equals("scissors"))
                {
                    Console.WriteLine("Rock crushes Scissors!");
                    return player1;
                }
                else if (player2.GetChoice().Equals("lizard"))
                {
                    Console.WriteLine("Rock crushes Lizard!");
                    return player1;
                }
                else
                {
                    Console.WriteLine("Spock vaporizes Rock!");
                    return player2;
                }
            }
            else if (player1.GetChoice().Equals("paper"))
            {
                if (player2.GetChoice().Equals("rock"))
                {
                    Console.WriteLine("Paper covers Rock!");
                    return player1;
                }
                else if (player2.GetChoice().Equals("scissors"))
                {
                    Console.WriteLine("Scissors cuts Paper!");
                    return player2;
                }
                else if (player2.GetChoice().Equals("lizard"))
                {
                    Console.WriteLine("Lizard eats Paper!");
                    return player2;
                }
                else
                {
                    Console.WriteLine("Paper disproves Spock!");
                    return player1;
                }
            }
            else if (player1.GetChoice().Equals("scissors"))
            {
                if (player2.GetChoice().Equals("rock"))
                {
                    Console.WriteLine("Rock crushes Scissors!");
                    return player2;
                }
                else if (player2.GetChoice().Equals("paper"))
                {
                    Console.WriteLine("Scissors cuts Paper!");
                    return player1;
                }
                else if (player2.GetChoice().Equals("lizard"))
                {
                    Console.WriteLine("Scissors decapitates Lizard!");
                    return player1;
                }
                else
                {
                    Console.WriteLine("Spock smashes Scissors!");
                    return player2;
                }
            }
            else if (player1.GetChoice().Equals("lizard"))
            {
                if (player2.GetChoice().Equals("rock"))
                {
                    Console.WriteLine("Rock crushes Lizard!");
                    return player2;
                }
                else if (player2.GetChoice().Equals("paper"))
                {
                    Console.WriteLine("Scissors decapitate Lizzard!");
                    return player2;
                }
                else if (player2.GetChoice().Equals("scissors"))
                {
                    Console.WriteLine("Lizard eats Paper!");
                    return player1;
                }
                else
                {
                    Console.WriteLine("Lizard poisons Spock!");
                    return player1;
                }
            }
            else
            {
                if (player2.GetChoice().Equals("rock"))
                {
                    Console.WriteLine("Spock vaporizes Rock!");
                    return player1;
                }
                else if (player2.GetChoice().Equals("paper"))
                {
                    Console.WriteLine("Paper disproves Spock!");
                    return player2;
                }
                else if (player2.GetChoice().Equals("scissors"))
                {
                    Console.WriteLine("Spock smashes Scissors!");
                    return player1;
                }
                else
                {
                    Console.WriteLine("Lizard Poisons Spock!");
                    return player2;
                }
            }
        }
        public static void displayRules()
        {
            Console.WriteLine("Welcome to RPSLS!\n");
            Console.WriteLine("Rules:\n\tRock crushes Scissors \n\tScissors cuts Paper \n\tPaper covers Rock \n\tRock crushes Lizard \n\tLizard poisons Spock \n\tSpock smashes Scissors \n\tScissors decapitates Lizard \n\tLizard eats Paper \n\tPaper disproves Spock \n\tSpock vaporizes Rock");
            Console.WriteLine("Press Enter to continue!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
