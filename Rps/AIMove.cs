using System;
namespace Rps
{
    public class AIMove
    {
        public Moves RandChoice()
        {
            var rnd = new Random();
            return (Moves)rnd.Next(1, Enum.GetNames(typeof(Moves)).Length + 1);
        }
    }
}
