using System.Collections.Generic;
using AdventOfCode.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCodeTests.Day2
{
    [TestClass]
    public class Puzzle2Tests
    {
        [TestMethod]
        public void CalculateAccuratePositionAndDepth_WithValidInput_ReturnsProductWithAim()
        {
            // Arrange
            int expected = 900;
            List<string> commandsAndAmount = new List<string>();
            commandsAndAmount.Add("forward 5");
            commandsAndAmount.Add("down 5");
            commandsAndAmount.Add("forward 8");
            commandsAndAmount.Add("up 3");
            commandsAndAmount.Add("down 8");
            commandsAndAmount.Add("forward 2");

            // Act
            Puzzle2 puzzle2 = new Puzzle2(commandsAndAmount);
            int actual = puzzle2.CalculateAccuratePositionAndDepth();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

