using System;
using NUnit.Framework;

namespace Rps.Tests
{
    [TestFixture]
    public class HelperTest
    {

        [Test]
        [TestCase('R', true)]
        [TestCase('P', true)]
        [TestCase('S', true)]
        [TestCase('A', false)]
        [TestCase('W', false)]
        public void RpsInputValidation(char input, bool expected)
        {
            bool output = Helper.RpsValidation(input);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        [TestCase('R', Moves.Rock)]
        [TestCase('P', Moves.Paper)]
        [TestCase('S', Moves.Scissors)]
        public void RpsInputValidation(char input, Moves expected)
        {
            Moves output = Helper.ConvertInput(input);
            Assert.That(output, Is.EqualTo(expected));
        }

    }
}
