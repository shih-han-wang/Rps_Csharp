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
        }
    }
}
