namespace AdventOfCodeTests.Day1;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Day1;
using System.Collections.Generic;

[TestClass]
public class Puzzle1Tests
{
    [TestMethod]
    public void GetIncreasingDepthMeasurementsCount_WithValidDepths_ReturnsCount()
    {
        // Arrange
        int expected = 7;
        List<int> depths = new()
        {
            199,
            200,
            208,
            210,
            200,
            207,
            240,
            269,
            260,
            263
        };

        // Act
        Puzzle1 puzzle1 = new(depths);
        int actual = puzzle1.GetIncreasingDepthMeasurementsCount();

        // Assert
        Assert.AreEqual(expected, actual);
    }
}

