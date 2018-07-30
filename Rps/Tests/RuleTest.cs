using System;
using NUnit.Framework;

namespace Rps.Tests
{
    [TestFixture]
    public class RuleTest
    {

        Player p1;
        Player p2;
        Player p3;

        [SetUp]
        public void GameSetUp()
        {
            p1 = new Player("p1");
            p2 = new Player("p2");
            p3 = new Player("p3");

            p1.Choice = Moves.Rock;
            p2.Choice = Moves.Paper;
            p3.Choice = Moves.Scissors;
        }


        [Test]
        public void ReturnWinnerPlayer()
        {
            Player winner1 = Rule.Winner(p1, p2);
            Player winner2 = Rule.Winner(p1, p3);
            Player winner3 = Rule.Winner(p2, p3);
            Player winner4 = Rule.Winner(p1, p1);

            Assert.That(winner1.Name, Is.EqualTo(p2.Name));
            Assert.That(winner2.Name, Is.EqualTo(p1.Name));
            Assert.That(winner3.Name, Is.EqualTo(p3.Name));
            Assert.That(winner4, Is.Null);
        }

    }
}
