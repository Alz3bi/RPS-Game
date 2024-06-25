using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    public class RPSGame
    {
        private Player player;
        private Player aiPlayer;

        public RPSGame(Player player, Player aiPlayer)
        {
            this.player = player;
            this.aiPlayer = aiPlayer;
        }

        public void PlayRound()
        {
            Console.WriteLine("Enter your choice (Rock, Paper, Scissors): ");

            string choice = Console.ReadLine().Trim();

            string playerChoice = player.MakeChoice(choice);
            while (playerChoice == "invalid")
            {
                Console.WriteLine("Invalid choice. Please enter Rock, Paper, or Scissors: ");
                choice = Console.ReadLine().Trim();
                playerChoice = player.MakeChoice(choice);
            }
            string aiChoice = aiPlayer.MakeChoice(choice);

            Console.WriteLine($"{player.Name} chooses {playerChoice}");
            Console.WriteLine($"{aiPlayer.Name} chooses {aiChoice}");

            CompareMoves(playerChoice, aiChoice);
        }


        
        //detects the winner of the round
        public string CompareMoves(string playerChoice, string aiChoice)
        {
            if (playerChoice == aiChoice)
            {
                Console.WriteLine("It's a tie!");
                return "Tie";
            }
            else if ((playerChoice == "Rock" && aiChoice == "Scissors") ||
                     (playerChoice == "Scissors" && aiChoice == "Paper") ||
                     (playerChoice == "Paper" && aiChoice == "Rock"))
            {
                Console.WriteLine($"{player.Name} wins!");
                player.Score++;
                return player.Name;
            }
            else
            {
                Console.WriteLine($"{aiPlayer.Name} wins!");
                aiPlayer.Score++;
                return aiPlayer.Name;
            }
        }

        public int DisplayScores()
        {
            Console.WriteLine($"Scores: {player.Name} - {player.Score}, {aiPlayer.Name} - {aiPlayer.Score}");
            return player.Score;
        }

        public void Interface()
        {
            Console.WriteLine("Rock, Paper, Scissors Game - Best of 3 Rounds");

            while (player.Score < 3 && aiPlayer.Score < 3)
            {
                PlayRound();
                DisplayScores();

                if (player.Score == 3 || aiPlayer.Score == 3)
                {
                    Console.WriteLine(player.Score == 3 ? $"{player.Name} wins the game!" : $"{aiPlayer.Name} wins the game!");
                    break;
                }
            }
            Console.WriteLine("Game over!");
        }
    }
}
