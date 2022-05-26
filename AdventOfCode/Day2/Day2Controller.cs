using System;
using System.Collections.Generic;
using AdventOfCode.Helper;

namespace AdventOfCode.Day2
{
    public static class Day2Controller
    {
        public static void Day2Puzzle1()
        {
            try
            {
                List<string> lines = FileHelper.GetLinesFromFile(Constants.NAVIGATION_FILE_PATH);
                Puzzle1 puzzle1 = new Puzzle1(lines);
                int res = puzzle1.CalculatePositionAndDepth();
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Day2Puzzle2()
        {
            try
            {
                List<string> lines = FileHelper.GetLinesFromFile(Constants.NAVIGATION_FILE_PATH);
                Puzzle2 puzzle2 = new Puzzle2(lines);
                int res = puzzle2.CalculateAccuratePositionAndDepth();
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

