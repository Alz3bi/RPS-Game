using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    
    public class Player
    {
        private static readonly Random random = new Random();
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsAI { get; private set; }

        public Player(string name, bool isAI = false)
        {
            Name = name;
            IsAI = isAI;
        }

        public string MakeChoice(String choice)
        {
            
            if (IsAI)
            {
                int rand = random.Next(1, 4);
                return rand switch
                {
                    1 => "Rock",
                    2 => "Paper",
                    3 => "Scissors",
                    _ => "Rock",
                };
            }
            else
            {
               

                switch (choice.ToLower())
                {
                    case "rock":
                        return "Rock";
                    case "paper":
                        return "Paper";
                    case "scissors":
                        return "Scissors";
                    default:
                        return "invalid";
                }
            }
        }
    }
}
