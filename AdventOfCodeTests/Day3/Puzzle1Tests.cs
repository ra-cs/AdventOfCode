namespace AdventOfCodeTests.Day3
{
    using System.Collections.Generic;
    using AdventOfCode.Day3;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Puzzle1Tests
    {
        [TestMethod]
        public void CalculatePowerConsumption_WithValidInput_ReturnsCorrectPowerConsumption()
        {
            // Arrange
            int expected = 198;
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
            Puzzle1 puzzle1 = new Puzzle1(binaryDiagnostics);
            int actual = puzzle1.CalculatePowerConsumption();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}