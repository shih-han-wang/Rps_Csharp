using System;
using NUnit.Framework;

namespace Rps.Tests
{
    [TestFixture]
    public class MessageTest
    {

        [Test]
        public void StartGameMessage()
        {

            string expected = "Please choose R (Rock) P (Paper) S (Scissors) "; 
            Assert.That(Message.StartGame(), Is.EqualTo(expected));

        }

    }
}
