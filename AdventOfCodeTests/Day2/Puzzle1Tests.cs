using System.Collections.Generic;
using AdventOfCode.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCodeTests.Day2
{
    [TestClass]
    public class Puzzle1Tests
    {
        [TestMethod]
        public void CalculatePositionAndDepth_WithValidInput_ReturnsProduct()
        {
            // Arrange
            int expected = 150;
            List<string> commandsAndAmount = new List<string>();
            commandsAndAmount.Add("forward 5");
            commandsAndAmount.Add("down 5");
            commandsAndAmount.Add("forward 8");
            commandsAndAmount.Add("up 3");
            commandsAndAmount.Add("down 8");
            commandsAndAmount.Add("forward 2");

            // Act
            Puzzle1 puzzle1 = new Puzzle1(commandsAndAmount);
            int actual = puzzle1.CalculatePositionAndDepth();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

