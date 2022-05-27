namespace AdventOfCode
{
    using System;
    using AdventOfCode.Day1;
    using AdventOfCode.Day2;
    using AdventOfCode.Day3;
    using AdventOfCode.ErrorHandling;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write(Constants.ENTER_DAY_PROMPT);
            string day = Console.ReadLine();

            Console.Write(Constants.ENTER_PUZZLE_NUMBER_PROMPT);
            string puzzleNumber = Console.ReadLine();

            switch (day)
            {
                case Constants.ONE:
                    Day1Controller.Day1Handler(puzzleNumber);
                    break;
                case Constants.TWO:
                    Day2Controller.Day2Handler(puzzleNumber);
                    break;
                case Constants.THREE:
                    Day3Controller.Day3Handler(puzzleNumber);
                    break;
                default:
                    ErrorMessages.PrintInvalidInputErrorMessage();
                    break;
            }
        }
    }
}