using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Arrays
{
    internal class PrintSpiralMatix
    {
        private int[][] matrix;
        public PrintSpiralMatix(int[][] _matrices)
        {
            matrix = _matrices;
        }
        public void PrintSpiral()
        {
            List<int> ints = new List<int>();
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int total_elements = rows * cols;

            int startingRow = 0;
            int endingCol = cols - 1;
            int endingRow = rows - 1;
            int startingCol = 0;

            int count = 0;
            while (count < total_elements)
            {
                //first row print
                for (int i = startingCol; i <= endingCol && count < total_elements; i++)
                {
                    ints.Add(matrix[startingRow][i]);
                    count++;
                }
                startingRow++;
                //last column print
                for (int i = startingRow; i <= endingRow && count < total_elements; i++)
                {
                    ints.Add(matrix[i][endingCol]);
                    count++;
                }
                endingCol--;
                //last column print
                for (int i = endingCol; i >= startingCol && count<total_elements; i--)
                {
                    ints.Add(matrix[rows - 1][i]);
                    count++;
                }
                endingRow--;
                //bottom to top 
                for (int i = endingRow; i >= startingRow && count<total_elements; i--)
                {
                    ints.Add(matrix[i][0]);
                }
                startingCol++;
            }
        }
    }
}
