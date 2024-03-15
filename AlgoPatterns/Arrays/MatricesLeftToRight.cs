using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Arrays
{
    internal class MatricesLeftToRight
    {
        private int[,] _matrices;
        public MatricesLeftToRight(int[,] matrices)
        {
            _matrices = matrices;
        }
        public void PrintWaveMatrix()
        {
            int m = _matrices.GetLength(0);
            int n = _matrices.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    //left to right
                    for (int r = 0; r < n; r++)
                    {
                        Console.Write(_matrices[i, r] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    //right to left
                    for (int r = n - 1; r >= 0; r--)
                    {
                        Console.Write(_matrices[i, r] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
