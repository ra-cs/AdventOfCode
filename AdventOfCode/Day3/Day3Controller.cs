namespace AdventOfCode.Day3
{
    using System;
    using System.Collections.Generic;
    using AdventOfCode.ErrorHandling;
    using AdventOfCode.Helper;

    public class Day3Controller
    {
        public static void Day3Handler(string puzzleNumber)
        {
            if (puzzleNumber.Equals(Constants.ONE))
            {
                Day3Controller.Day3Puzzle1();
            }
            else
            {
                ErrorMessages.PrintInvalidInputErrorMessage();
            }
        }

        public static void Day3Puzzle1()
        {
            try
            {
                List<string> lines = FileHelper.GetLinesFromFile(Constants.BINARY_DIAGNOSTICS_FILE_PATH);
                Puzzle1 puzzle1 = new Puzzle1(lines);
                int powerConsumption = puzzle1.CalculatePowerConsumption();
                Console.WriteLine(powerConsumption);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Day3Puzzle2()
        {
            try
            {
                List<string> lines = FileHelper.GetLinesFromFile(Constants.BINARY_DIAGNOSTICS_FILE_PATH);
                Puzzle2 puzzle2 = new Puzzle2(lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}