using System;
using AdventOfCode.Day1;
using AdventOfCode.Day2;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Constants.ENTER_DAY_PROMPT);
            string day = Console.ReadLine();

            Console.Write(Constants.ENTER_PUZZLE_NUMBER_PROMPT);
            string puzzleNumber = Console.ReadLine();

            switch(day)
            {
                case Constants.ONE:
                    if (puzzleNumber.Equals(Constants.ONE))
                        Day1Controller.Day1Puzzle1();
                    else if (puzzleNumber.Equals(Constants.TWO))
                        Day1Controller.Day1Puzzle2();
                    else
                        PrintInvalidInputErrorMessage();
                    break;
                case Constants.TWO:
                    if (puzzleNumber.Equals(Constants.ONE))
                        Day2Controller.Day2Puzzle1();
                    else
                        PrintInvalidInputErrorMessage();
                    break;
                default:
                    PrintInvalidInputErrorMessage();
                    break;
            }

        }

        static void PrintInvalidInputErrorMessage()
        {
            Console.WriteLine(Constants.INVALID_INPUT_MESSAGE);
        }
    }
}

