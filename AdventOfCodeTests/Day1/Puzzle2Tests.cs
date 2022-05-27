namespace AdventOfCodeTests.Day1
{
    using System.Collections.Generic;
    using AdventOfCode.Day1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Puzzle2Tests
    {
        [TestMethod]
        public void GetIncreasingMeasurementCount_WithValidMeasurements_ReturnsCount()
        {
            // Arrange
            int expected = 5;
            List<int> depths = new List<int>()
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
            Puzzle2 puzzle2 = new Puzzle2(depths);
            int actual = puzzle2.GetIncreasingMeasurementCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}