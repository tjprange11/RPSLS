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
            Console.WriteLine("Welcome to RPSLS!");
            Console.WriteLine("Rules:\nRock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock");
            Console.WriteLine("Press Enter to continue!");
            Console.ReadLine();
            int scoreToWin = GetBestOf();
            Console.WriteLine("What is your name Player 1?");
            Human player1 = new Human(Console.ReadLine());
            Console.WriteLine("Do you have another player to play against? 'yes' or 'no'");
            string userInputString = Console.ReadLine().ToLower();
            while(!validateYesNo(userInputString))
            {
                Console.WriteLine("Invalid Answer!");
                Console.WriteLine("Do you have another player to play against? 'yes' or 'no'");
                userInputString = Console.ReadLine().ToLower();
            }
            if(userInputString.Equals("yes"))
            {
                CPU player2 = new CPU();
                Console.WriteLine("Alright let's begin then!");
                while(player1.GetScore() < 2 && player2.GetScore() < 2)
            }
            
        }
        public string AskForChoice()
        {
            Console.WriteLine("Please choose : 'rock' , 'paper' , 'scissors' , 'lizard' , or 'spock'");
            return Console.ReadLine().ToLower();
        }
        public static int GetBestOf()
        {
            Console.WriteLine("How many games would you like to play best of? Ex. Best of 7 - First to 4 wins");
            string userInput = Console.ReadLine();
            int bestOf;
            if (int.TryParse(userInput, out bestOf))
            {
                return bestOf;
            }
            Console.WriteLine("Invalid Entry!");
            return GetBestOf();
        }
        public bool validateChoice(string userInput, List<string> choices)
        {
            foreach(string choice in choices)
            {
                if(userInput.Equals(choice))
                {
                    return true;
                }
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
        public bool validateOdd(int num)
        {
            if(num%2 == 1)
            {
                return true;
            }
            return false;
        }
        public bool CheckIfTie(string player1, string player2)
        {
            if(player1.Equals(player2))
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
    }
}
