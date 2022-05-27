namespace AdventOfCode.Day3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Puzzle1
    {
        private readonly List<string> binaryDiagnostics;
        private readonly int rowLength;
        private readonly int columnLength;

        public Puzzle1(List<string> binaryDiagnostics)
        {
            this.binaryDiagnostics = binaryDiagnostics;
            this.rowLength = this.binaryDiagnostics.Count;
            this.columnLength = this.binaryDiagnostics[0].Length;
        }

        public int CalculatePowerConsumption()
        {
            char[,] binaryDiagnosticsMatrix = MatrixHelper.BuildCharacterMatrix(binaryDiagnostics);

            StringBuilder gamma = new StringBuilder();
            StringBuilder epsilon = new StringBuilder();

            int zeroCount = 0;
            int oneCount = 0;
           

            for (int i = 0; i < this.columnLength; i++)
            {
                for (int j = 0; j < this.rowLength; j++)
                {
                    char currentVal = binaryDiagnosticsMatrix[j, i];

                    if (currentVal.Equals('0'))
                    {
                        zeroCount++;
                    }
                    else if (currentVal.Equals('1'))
                    {
                        oneCount++;
                    }
                }

                if (zeroCount > oneCount)
                {
                    gamma.Append('0');
                    epsilon.Append('1');
                }
                else if (oneCount > zeroCount)
                {
                    gamma.Append('1');
                    epsilon.Append('0');
                }

                zeroCount = 0;
                oneCount = 0;
            }

            int gammaVal = Convert.ToInt32(gamma.ToString(), 2);
            int epsilonVal = Convert.ToInt32(epsilon.ToString(), 2);

            int powerConsumption = gammaVal * epsilonVal;

            return powerConsumption;
        }
    }
}