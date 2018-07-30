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
        public void ConvertRpsInput(char input, Moves expected)
        {
            Moves output = Helper.ConvertInput(input);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        [TestCase('r', true)]
        [TestCase('t', true)]
        [TestCase('s',false)]
        [TestCase('g', false)]
        public void ChooseModeInputValidation(char input, bool expected)
        {
            bool output = Helper.ChooseModeValidation(input);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        [TestCase('R', Modes.Random)]
        [TestCase('T', Modes.Tactical)]
        public void ConvertChooseModeInput(char input, Modes expected)
        {
            Modes output = Helper.ConvertModeInput(input);
            Assert.That(output, Is.EqualTo(expected));
        }


    }
}
