using System;

namespace Rps
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player p1 = new Player("User");
            Player p2 = new Player("Computer");

            Game game = new Game(p1, p2);
            AIMove aiMove = new AIMove();

            int totalTurn = game.TotalTurn;
            int halfTurn = (int)Math.Ceiling((double)totalTurn / 2);

            do
            {
                game.p1.Choice = game.GetUerInput();
                game.p2.Choice = aiMove.RandChoice();
                Console.WriteLine(game.p1.Choice);
                Console.WriteLine(game.p2.Choice);

            } while (game.TotalTurn > 0);

        }
    }
}
