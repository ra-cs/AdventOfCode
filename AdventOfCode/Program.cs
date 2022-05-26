using System;
using System.Collections.Generic;
using AdventOfCode.Helper;

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
                        Day1Puzzle1();
                    else if (puzzleNumber.Equals(Constants.TWO))
                        Day1Puzzle2();
                    else
                        PrintInvalidInputErrorMessage();
                    break;
                default:
                    PrintInvalidInputErrorMessage();
                    break;
            }

        }

        static void Day1Puzzle1()
        {
            try
            {
                List<int> numList = FileHelper.GetNumListFromFile(Constants.DEPTH_MEASUREMENTS_FILE_PATH);
                Puzzle1 puzzle1 = new Puzzle1(numList);
                int increasingDepthCount = puzzle1.GetIncreasingDepthMeasurementsCount();
                Console.WriteLine(increasingDepthCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Day1Puzzle2()
        {
            try
            {
                List<int> numList = FileHelper.GetNumListFromFile(Constants.DEPTH_MEASUREMENTS_FILE_PATH);
                Puzzle2 puzzle2 = new Puzzle2(numList);
                int increasingMeasurementCount = puzzle2.GetIncreasingMeasurementCount();
                Console.WriteLine(increasingMeasurementCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PrintInvalidInputErrorMessage()
        {
            Console.WriteLine(Constants.INVALID_INPUT_MESSAGE);
        }
    }
}

