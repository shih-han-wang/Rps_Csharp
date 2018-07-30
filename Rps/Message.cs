using System;
namespace Rps
{
    public class Message
    {
        public static string StartGame()
        {
            string message = "Please choose ";

            foreach (string move in Enum.GetNames(typeof(Moves)))
                message += $"{move[0]} ({move}) ";
            
            return message;
        }
    }
}
