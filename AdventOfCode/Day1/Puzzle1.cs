using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode
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

