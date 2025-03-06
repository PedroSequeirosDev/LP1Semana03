using System;
using GameItem;
using GameStatus;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItems player1 = Enum.Parse<GameItems>(args[0]);
            GameItems player2 = Enum.Parse<GameItems>(args[1]);

            GameStates result = RockPaperScissors(player1, player2);
            switch (result)
            {
                case GameStates.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStates.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStates.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStates RockPaperScissors(GameItems player1, GameItems player2)
        {
            if (player1 == player2)
            {
                return GameStates.Draw; // Draw
            }
            if ((player1 == GameItems.Rock && player2 == GameItems.Scissors) ||
                (player1 == GameItems.Scissors) && (player2 == GameItems.Paper) ||
                (player1 == GameItems.Paper) && (player2 == GameItems.Rock))
            {
                return GameStates.Player1Wins; // Player 1 wins
            }
            else
            {
                return GameStates.Player2Wins; // Player 2 wins
            }
        }
    }
}
