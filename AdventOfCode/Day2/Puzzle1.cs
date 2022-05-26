using System;
using System.Collections.Generic;

namespace AdventOfCode.Day2
{
	public class Puzzle1
	{
		private List<string> commandAndAmounts;

		public Puzzle1(List<string> commandAndAmounts)
		{
			this.commandAndAmounts = commandAndAmounts;
		}

		public int CalculatePositionAndDepth()
        {
			int horizontalPosition = 0;
			int depth = 0;

			foreach (string line in commandAndAmounts)
			{
				string[] commandAndAmount = line.Split(' ');
				Enum.TryParse(commandAndAmount[0], out Commands command);
				int amount = int.Parse(commandAndAmount[1]);

				switch(command)
                {
					case Commands.forward:
						horizontalPosition += amount;
						break;
					case Commands.up:
						depth -= amount;
						break;
					case Commands.down:
						depth += amount;
						break;
					default:
						break;
                }
			}

			return horizontalPosition * depth;
		}
	}
}

