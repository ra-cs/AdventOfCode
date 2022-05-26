using System;
using System.Collections.Generic;

namespace AdventOfCode.Day1
{
    public class Puzzle2
    {
        private List<int> depthMeasurements;

        public Puzzle2(List<int> depthMeasurements)
        {
            this.depthMeasurements = depthMeasurements;
        }

        public int GetIncreasingMeasurementCount()
        {
            int increasingCount = 0;
            Nullable<int> prev = null;

            for (int i = 2; i < depthMeasurements.Count; i++)
            {
                int currDepth = depthMeasurements[i - 2] +
                                depthMeasurements[i - 1] +
                                depthMeasurements[i];

                if (prev == null)
                {
                    prev = currDepth;
                    continue;
                }

                if (currDepth > prev)
                    increasingCount++;

                prev = currDepth;
            }

            return increasingCount;
        }
    }
}

