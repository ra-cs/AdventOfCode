using System;
using System.Collections.Generic;

namespace AdventOfCode.Day3
{
    public static class MatrixHelper
    {
      public static char[,] BuildCharacterMatrix(List<string> wordList)
      {
            int rowLength = wordList.Count;
            int columnLength = wordList[0].Length;
            char[,] matrix = new char[rowLength, columnLength];

            for (int i = 0; i < rowLength; i++)
            {
                char[] word = wordList[i].ToCharArray();
                for (int j = 0; j < columnLength; j++)
                {
                    matrix[i, j] = word[j];
                }
            }

            return matrix;
      }
    }
}

