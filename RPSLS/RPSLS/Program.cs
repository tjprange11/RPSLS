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
    }
}
