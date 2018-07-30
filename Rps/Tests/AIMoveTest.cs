using System;
using NUnit.Framework;

namespace Rps.Tests
{
    [TestFixture]
    public class AIMoveTest
    {

        [Test]
        public void ReturnRandChoice()
        {
            AIMove aiMove = new AIMove();
            Assert.IsInstanceOf<Moves>(aiMove.RandChoice());
        }

    }
}
