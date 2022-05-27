namespace AdventOfCode.Day1;

using System.Collections.Generic;

public class Puzzle2
{
    private readonly List<int> depthMeasurements;

    public Puzzle2(List<int> depthMeasurements) => this.depthMeasurements = depthMeasurements;

    public int GetIncreasingMeasurementCount()
    {
        int increasingCount = 0;
        int? prev = null;

        for (int i = 2; i < this.depthMeasurements.Count; i++)
        {
            int currDepth = this.depthMeasurements[i - 2] +
                            this.depthMeasurements[i - 1] +
                            this.depthMeasurements[i];

            if (prev == null) {
                prev = currDepth;
                continue;
            }

            if (currDepth > prev)
            {
                increasingCount++;
            }

            prev = currDepth;
        }

        return increasingCount;
    }
}

