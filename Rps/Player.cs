using System;
namespace Rps
{
    public class Player
    {
        private string name;
        public int score;

        public Moves Choice { get; set; }

        public Player(string nameInput)
        {
            score = 0;
            name = nameInput;
        }

        public string Name
        {
            get { return name; }
        }

    }
}
