using System;
namespace Rps
{
    public class Rule
    {
        public static Player Winner(Player p1, Player p2)
        {
            int p1Value = (int)p1.Choice;
            int p2Value = (int)p2.Choice;

            Player result = null;

            if (p1Value % 3 + 1 == p2Value)
            {
                result = p2;
                p2.score++;
            }
            else if (p2Value % 3 + 1 == p1Value)
            {
                result = p1;
                p1.score++;
            }

            return result;
        }
    }
}
