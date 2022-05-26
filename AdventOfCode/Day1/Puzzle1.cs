using System;
using System.Collections.Generic;

namespace AdventOfCode.Day1
{
    public class Puzzle1
	{
		private List<int> depthMeasurements;
		
		public Puzzle1(List<int> depthMeasurements)
		{
			this.depthMeasurements = depthMeasurements;
		}

		public int GetIncreasingDepthMeasurementsCount()
        {
			Nullable<int> prev = null;
			int increasingCount = 0;
			foreach (int depth in depthMeasurements)
            {
				if (prev == null)
                {
					prev = depth;
					continue;
                }

				if (depth > prev)
					increasingCount++;

				prev = depth;
            }

			return increasingCount;
        }

	}
}

