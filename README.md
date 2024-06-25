# Rock, Paper, Scissors Game

This is a simple console application for the classic game Rock, Paper, Scissors. The game allows a player to compete against an AI opponent in a best of three rounds match.

## Getting Started

To get started with this game, clone this repository to your local machine. You will need to have .NET installed to run the application.

### Prerequisites

- .NET 7.0 or higher

### Installation

1. Clone the repository to your local machine.
2. Navigate to the cloned directory.
3. Build the solution using Visual Studio 2022 or by running `dotnet build` in the terminal.

### Running the Game

To start the game, navigate to the directory containing the compiled application and run the following command in the terminal:

```
dotnet run
```


Follow the on-screen instructions to play the game. You will be prompted to enter your name and make your choices for Rock, Paper, or Scissors in each round.

## How to Play

- The game is played in rounds.
- In each round, you will choose between Rock, Paper, or Scissors.
- The AI opponent will randomly choose its move.
- The winner of each round is determined by the classic rules:
  - Rock crushes Scissors
  - Scissors cuts Paper
  - Paper covers Rock
- The first to win three rounds wins the game.

## Code Structure

The solution is structured into four main files:

- `Program.cs`: Contains the `Main` method and the game's entry point.
- `RPSGame.cs`: Contains the game logic and the main game loop.
- `Player.cs`: Represents a player in the game and handles the choice logic.
- `UnitTest1.cs`: Contains unit tests for the game logic.

## Running the Tests

To run the unit tests, navigate to the test project directory and run the following command:

```
dotnet test
```


## Contributing

Contributions are welcome. Please feel free to fork the repository and submit pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
