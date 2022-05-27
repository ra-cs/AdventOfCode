namespace AdventOfCode.Day3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Puzzle1
    {
        private readonly List<string> binaryDiagnostics;

        public Puzzle1(List<string> binaryDiagnostics) => this.binaryDiagnostics = binaryDiagnostics;

        public int CalculatePowerConsumption()
        {
            int rowLength = this.binaryDiagnostics.Count;
            int columnLength = this.binaryDiagnostics[0].Length;
            char[,] binaryDiagnosticsMatrix = new char[rowLength, columnLength];

            for (int i = 0; i < binaryDiagnostics.Count; i++)
            {
                char[] splitBinaryNum = binaryDiagnostics[i].ToCharArray();
                PopulateRow(binaryDiagnosticsMatrix, i, columnLength, splitBinaryNum);
            }

            StringBuilder gamma = new StringBuilder();
            StringBuilder epsilon = new StringBuilder();

            int zeroCount = 0;
            int oneCount = 0;

            for (int i = 0; i < columnLength; i++)
            {
                for (int j = 0; j < rowLength; j++)
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


        private void PopulateRow(char[,] matrix, int rowNumber, int numberOfColumns, char[] binaryNum)
        {
            for (int i = 0; i < numberOfColumns; i++)
            {
                matrix[rowNumber,i] = binaryNum[i];
            }
        }

        private void PrintMatrix(char[,] matrix, int rowLength, int columnLength)
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

    }
}