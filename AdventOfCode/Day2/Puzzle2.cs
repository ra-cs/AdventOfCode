using System;
using System.Collections.Generic;

namespace AdventOfCode.Day2
{
    public class Puzzle2
	{
		private List<string> commandAndAmounts;

		public Puzzle2(List<string> commandAndAmounts)
		{
			this.commandAndAmounts = commandAndAmounts;
		}

		public int CalculateAccuratePositionAndDepth()
        {
			int horizontalPosition = 0;
			int depth = 0;
			int aim = 0;

			foreach (string line in commandAndAmounts)
			{
				string[] commandAndAmount = line.Split(' ');
				Enum.TryParse(commandAndAmount[0], out Commands command);
				int amount = int.Parse(commandAndAmount[1]);

				switch (command)
				{
					case Commands.forward:
						horizontalPosition += amount;
						depth += (aim * amount);
						break;
					case Commands.up:
						aim -= amount;
						break;
					case Commands.down:
						aim += amount;
						break;
					default:
						break;
				}
			}

			return horizontalPosition * depth;
		}
	}
}

