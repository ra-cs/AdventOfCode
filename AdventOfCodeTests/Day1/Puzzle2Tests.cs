using System.Collections.Generic;
using AdventOfCode.Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCodeTests.Day1
{
    [TestClass]
    public class Puzzle2Tests
    {
        [TestMethod]
        public void GetIncreasingMeasurementCount_WithValidMeasurements_ReturnsCount()
        {
            // Arrange
            int expected = 5;
            List<int> depths = new List<int>();
            depths.Add(199);
            depths.Add(200);
            depths.Add(208);
            depths.Add(210);
            depths.Add(200);
            depths.Add(207);
            depths.Add(240);
            depths.Add(269);
            depths.Add(260);
            depths.Add(263);

            // Act
            Puzzle2 puzzle2 = new Puzzle2(depths);
            int actual = puzzle2.GetIncreasingMeasurementCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

