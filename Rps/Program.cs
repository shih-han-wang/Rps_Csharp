using System;

namespace Rps
{
    class Program
    {
        public static void Main(string[] args)
        {

            Player p1 = new Player("User");
            Player p2 = new Player("Computer");

            Game game = new Game(p1, p2);
            AIMove aiMove = new AIMove();

            Modes mode = aiMove.UserChooseMode();

            int totalTurn = game.TotalTurn;
            int halfTurn = (int)Math.Ceiling((double)totalTurn / 2);

            do
            {
                game.p1.Choice = game.GetUserInput();

                if (mode == Modes.Tactical)
                {
                    game.p2.Choice = aiMove.TacticalMove;
                    aiMove.TacticalMove = aiMove.SetTacticalMove(game.p1.Choice);
                }
                else
                {
                    game.p2.Choice = aiMove.RandChoice();
                }
                    
                game.TurnFinished();
                Console.WriteLine("---------------------");

                if (p1.score == halfTurn || p2.score == halfTurn)
                    break;

            } while (game.TotalTurn > 0);

            game.Over();

        }
    }
}
