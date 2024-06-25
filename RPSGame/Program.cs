namespace RPSGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");

                // Initialize the human player
                Console.Write("Enter your name: ");
                string playerName = GetName();
                Player humanPlayer = new Player(playerName);

                // Initialize the AI player
                Player aiPlayer = new Player("AI", true);

                // Initialize and start the game
                RPSGame game = new RPSGame(humanPlayer, aiPlayer);
                game.Interface();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public static string GetName()
        {
            string name = Console.ReadLine().Trim();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter a valid Name");
                name = Console.ReadLine().Trim();
            }
            return name;
        }
    }
}
