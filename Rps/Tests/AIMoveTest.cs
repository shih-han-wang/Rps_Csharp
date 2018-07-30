using System;
using NUnit.Framework;

namespace Rps.Tests
{
    [TestFixture]
    public class AIMoveTest
    {
        AIMove aiMove;

        [SetUp]
        public void SetUp()
        {
            aiMove = new AIMove();
        }

        [Test]
        public void ReturnRandChoice()
        {
            Assert.IsInstanceOf<Moves>(aiMove.RandChoice());
        }

        [Test]
        public void TacticalMoveReturnRandByDefault()
        {
            Assert.IsInstanceOf<Moves>(aiMove.TacticalMove);
        }

        [Test]
        [TestCase(Moves.Rock, Moves.Paper)]
        [TestCase(Moves.Paper, Moves.Scissors)]
        [TestCase(Moves.Scissors, Moves.Rock)]
        public void ReturnNextTacticalMove(Moves input, Moves expected)
        {
            Moves output = aiMove.SetTacticalMove(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void SetAndGetTacticalMove()
        {
            aiMove.TacticalMove = aiMove.SetTacticalMove(Moves.Rock);

            Assert.That(aiMove.TacticalMove, Is.EqualTo(Moves.Paper));
        }

    }
}
