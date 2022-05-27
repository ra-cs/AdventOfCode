namespace AdventOfCodeTests.Day2;

using System.Collections.Generic;
using AdventOfCode.Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class Puzzle2Tests
{
    [TestMethod]
    public void CalculateAccuratePositionAndDepth_WithValidInput_ReturnsProductWithAim()
    {
        // Arrange
        int expected = 900;
        List<string> commandsAndAmount = new()
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        };

        // Act
        Puzzle2 puzzle2 = new(commandsAndAmount);
        int actual = puzzle2.CalculateAccuratePositionAndDepth();

        // Assert
        Assert.AreEqual(expected, actual);
    }
}

