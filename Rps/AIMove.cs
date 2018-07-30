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
            char userInput;

            do
            {
                Console.WriteLine(Message.ChooseMode());
                if (!char.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("This is not a character");
                }

            } while (!Helper.ChooseModeValidation(userInput));

            return Helper.ConvertModeInput(userInput);

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
