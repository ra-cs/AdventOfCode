namespace AdventOfCode.Day3;

using System;
using System.Collections.Generic;
using AdventOfCode.Helper;

public class Day3Controller
{

    public static void Day3Puzzle1()
    {
        try
        {
            List<string> lines = FileHelper.GetLinesFromFile(Constants.BINARY_DIAGNOSTICS_FILE_PATH);
            Puzzle1 puzzle1 = new(lines);
            int powerConsumption = puzzle1.CalculatePowerConsumption();
            Console.WriteLine(powerConsumption);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}

