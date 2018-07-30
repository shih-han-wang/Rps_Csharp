using System;
namespace Rps
{
    public enum Modes { Random = 1, Tactical };

    public class AIMove
    {

        public Moves TacticalMove { get; set; }

        public AIMove()
        {
            TacticalMove = this.RandChoice();
        }

        public Moves RandChoice()
        {
            var rnd = new Random();
            return (Moves)rnd.Next(1, Enum.GetNames(typeof(Moves)).Length + 1);
        }

        public Modes UserChooseMode()
        {
            string userInput;
            char inputChar;

            do
            {
                Console.WriteLine(Message.ChooseMode());
                userInput = Console.ReadLine();
                inputChar = Convert.ToChar(userInput);

            } while (!Helper.ChooseModeValidation(inputChar));

            return Helper.ConvertModeInput(inputChar);

        }

        public Moves SetTacticalMove(Moves userInput)
        {
            int value = (int)userInput;

            if (value == Enum.GetValues(typeof(Moves)).Length)
                return (Moves)1;
            else
                return (Moves)value + 1;

        }
    }
}
