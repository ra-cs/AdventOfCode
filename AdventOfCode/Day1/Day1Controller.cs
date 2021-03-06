namespace AdventOfCode.Day1
{
    using System;
    using System.Collections.Generic;
    using AdventOfCode.ErrorHandling;
    using AdventOfCode.Helper;

    public static class Day1Controller
    {
        public static void Day1Handler(string puzzleNumber)
        {
            if (puzzleNumber.Equals(Constants.ONE))
            {
                Day1Controller.Day1Puzzle1();
            }
            else if (puzzleNumber.Equals(Constants.TWO))
            {
                Day1Controller.Day1Puzzle2();
            }
            else
            {
                ErrorMessages.PrintInvalidInputErrorMessage();
            }
        }

        public static void Day1Puzzle1()
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

        public static void Day1Puzzle2()
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
    }
}