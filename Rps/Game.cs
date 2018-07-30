using System;
namespace Rps
{
    public enum Moves { Rock = 1, Paper, Scissors };

    public class Game
    {
        private int totalTurn;
        public Player p1;
        public Player p2;

        public Game(Player player1, Player player2, int turn = 3)
        {
            totalTurn = turn;
            p1 = player1;
            p2 = player2;
        }

        public int TotalTurn
        {
            get { return totalTurn; }
        }

        public Moves GetUerInput()
        {
            string userInput;
            char inputChar;

            do
            {
                Console.WriteLine(Message.StartGame());
                userInput = Console.ReadLine();
                inputChar = Convert.ToChar(userInput);

            } while (!Helper.RpsValidation(inputChar));

            return Helper.ConvertInput(inputChar);

        }

        public void TurnFinished()
        {
            Player winner = Rule.Winner(p1, p2);

            string choicesMessage = Message.TurnFinished(p1.Name, p1.Choice, p2.Name, p2.Choice);
            string winnerMessage = Message.TurnWinner(winner);

            Console.WriteLine(choicesMessage);
            Console.WriteLine(winnerMessage);

            totalTurn--;
        }

        public void Over()
        {
            Player winner;

            if (p1.score == p2.score)
                winner = null;
            else
                winner = p1.score > p2.score ? p1 : p2;

            Console.WriteLine(Message.GameWinner(winner));
        }


    }
}
