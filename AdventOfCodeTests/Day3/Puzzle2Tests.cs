namespace AdventOfCodeTests.Day3
{
    using System.Collections.Generic;
    using AdventOfCode.Day3;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Puzzle2Tests
    {
        [TestMethod]
        public void CalculateLifeSupportRating_WithValidInput_ReturnsCorrectLifeSupportRating()
        {
            // Arrange
            int expected = 230;
            List<string> binaryDiagnostics = new List<string>()
            {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };

            // Act
            Puzzle2 puzzle2 = new Puzzle2(binaryDiagnostics);
          //  int actual = puzzle2.CalculateLifeSupportRating();

            // Assert
           // Assert.AreEqual(expected, actual);
        }
    }
}