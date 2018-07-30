using System;
using NUnit.Framework;

namespace Rps.Tests
{
    [TestFixture]
    public class GameTest
    {
        Game game;

        [SetUp]
        public void GameSetUp() 
        {
            Player p1 = new Player("User");
            Player p2 = new Player("Computer");

            game = new Game(p1, p2);
        }

        [Test]
        public void InitializeGameVariable()
        {
            Assert.That(game.TotalTurn, Is.EqualTo(3));
            Assert.That(game.p1.Name, Is.EqualTo("User"));
            Assert.That(game.p2.Name, Is.EqualTo("Computer"));
        }

    }
}
