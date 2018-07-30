using System;
namespace Rps
{
    public class Helper
    {
        public static bool RpsValidation(char input)
        {

            char inputUpper = Char.ToUpper(input);

            if (inputUpper != 'R' && inputUpper != 'P' && inputUpper != 'S')
            {
                Console.WriteLine("Please enter the valid character");
                return false;
            }

            return true;

        }

        public static Moves ConvertInput(char input)
        {
            Moves result = 0;

            switch (Char.ToUpper(input))
            {
                case 'R':
                    result = Moves.Rock;
                    break;
                case 'P':
                    result = Moves.Paper;
                    break;
                case 'S':
                    result = Moves.Scissors;
                    break;
            }

            return result;
        }

        public static bool ChooseModeValidation(char input)
        {

            char inputUpper = Char.ToUpper(input);

            if (inputUpper != 'R' && inputUpper != 'T')
            {
                Console.WriteLine("Please enter the valid character");
                return false;
            }

            return true;

        }

        public static Modes ConvertModeInput(char input)
        {
            Modes result = 0;

            switch (Char.ToUpper(input))
            {
                case 'R':
                    result = Modes.Random;
                    break;
                case 'T':
                    result = Modes.Tactical;
                    break;
            }

            return result;
        }
    }
}
