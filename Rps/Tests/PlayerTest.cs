using System;
using NUnit.Framework;

namespace Rps.Tests
{
    [TestFixture]
    public class PlayerTest
    {

        [Test]
        public void ReturnPlayerNameAndScore()
        {
            Player player = new Player("myName");
            Assert.That(player.Name, Is.EqualTo("myName"));
            Assert.That(player.score, Is.EqualTo(0));
        }

    }
}
