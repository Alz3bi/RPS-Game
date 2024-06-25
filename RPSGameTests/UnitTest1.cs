using RPSGame;
namespace RPSGameTests
{
    public class UnitTest1
    {
        [Fact]
        public void WinnerCheck()
        {
            // Arrange
            var player = new Player("Player1");
            var aiPlayer = new Player("AI", true);
            // Act
            RPSGame.RPSGame game = new RPSGame.RPSGame(player, aiPlayer);
            string winner = game.CompareMoves("Rock", "Scissors");
            // Assert
            Assert.Equal("Player1", winner);
        }
        [Fact]
        public void ScoreUpdate()
        {
            //Arrange
            // Arrange
            var player = new Player("Player1");
            var aiPlayer = new Player("AI", true);
            // Act
            RPSGame.RPSGame game = new RPSGame.RPSGame(player, aiPlayer);
            string winner = game.CompareMoves("Rock", "Scissors");
            int resault = game.DisplayScores();
            // Assert
            Assert.Equal(1, resault);

        }
    }
}