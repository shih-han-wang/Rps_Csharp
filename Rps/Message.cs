using System;
namespace Rps
{
    public class Message
    {
        public static string StartGame()
        {
            string message = "Please choose ";

            foreach (string move in Enum.GetNames(typeof(Moves)))
                message += $"{move[0]} ({move}) ";
            
            return message;
        }

        public static string TurnFinished(string p1name, Moves p1choice, string p2name, Moves p2choice)
        {
            string message =
                $"{p1name}'s choice: {p1choice} " +
                $"{Environment.NewLine}" +
                $"{p2name}'s choice: {p2choice}";

            return message;
        }

        public static string TurnWinner(Player winner)
        {
            if (winner == null)
                return "This turn is a tie.";
            else
                return $"{winner.Name} won this turn!";
        }

        public static string GameWinner(Player winner)
        {
            if (winner == null)
                return "Game Over. It's a tie.";
            else
                return $"Game Over. {winner.Name} won!";
        }
    }
}
