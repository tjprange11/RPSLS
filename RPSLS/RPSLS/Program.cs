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
            
        }
        public string AskForChoice()
        {
            Console.WriteLine("Please choose : 'rock' , 'paper' , 'scissors' , 'lizard' , or 'spock'");
            return Console.ReadLine().ToLower();
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
