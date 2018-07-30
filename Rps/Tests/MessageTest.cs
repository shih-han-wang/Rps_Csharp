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

        [Test]
        public void TurnFinishedMessage()
        {
            
            string output = Message.TurnFinished("User", Moves.Rock, "Computer", Moves.Paper);
            string expected = "User's choice: Rock \nComputer's choice: Paper";
            Assert.That(output, Is.EqualTo(expected));

        }

        [Test]
        public void ReturnTurnTieMessage()
        {
            
            string expected = "This turn is a tie.";
            string output = Message.TurnWinner(null);

            Assert.That(output, Is.EqualTo(expected));
           
        }

        [Test]
        public void ReturnTurnWinnerMessage()
        {
            string expected = "User won this turn!";

            Player p1 = new Player("User");
            string output = Message.TurnWinner(p1);


            Assert.That(output, Is.EqualTo(expected));

        }

        [Test]
        public void ReturnGameTieMessage()
        {

            string expected = "Game Over. It's a tie.";
            string output = Message.GameWinner(null);

            Assert.That(output, Is.EqualTo(expected));

        }

        [Test]
        public void ReturnGameWinnerMessage()
        {
            
            string expected = "Game Over. Computer won!";

            Player p1 = new Player("Computer");
            string output = Message.GameWinner(p1);

            Assert.That(output, Is.EqualTo(expected));

        }
    }
}
