namespace AdventOfCode.Day1;
using System.Collections.Generic;

public class Puzzle1
{
    private readonly List<int> depthMeasurements;

    public Puzzle1(List<int> depthMeasurements) => this.depthMeasurements = depthMeasurements;

    public int GetIncreasingDepthMeasurementsCount()
    {
        int? prev = null;
        int increasingCount = 0;
        foreach (int depth in this.depthMeasurements)
        {
            if (prev == null)
            {
                prev = depth;
                continue;
            }

            if (depth > prev)
            {
                increasingCount++;
            }

            prev = depth;
        }

        return increasingCount;
    }

}

