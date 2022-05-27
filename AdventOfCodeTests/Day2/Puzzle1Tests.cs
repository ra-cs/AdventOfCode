namespace AdventOfCodeTests.Day2
{
    using System.Collections.Generic;
    using AdventOfCode.Day2;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Puzzle1Tests
    {
        [TestMethod]
        public void CalculatePositionAndDepth_WithValidInput_ReturnsProduct()
        {
            // Arrange
            int expected = 150;
            List<string> commandsAndAmount = new List<string>()
            {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"
            };

            // Act
            Puzzle1 puzzle1 = new Puzzle1(commandsAndAmount);
            int actual = puzzle1.CalculatePositionAndDepth();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}