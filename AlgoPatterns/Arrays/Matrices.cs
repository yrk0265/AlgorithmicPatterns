using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Arrays
{
    internal class WavePrintMatrices
    {
        private int[,] _matrices;
        public WavePrintMatrices(int[,] matrices)
        {
            _matrices = matrices;
        }
        public void PrintWaveMatrix()
        {
            int m = _matrices.GetLength(0);
            int n = _matrices.GetLength(1);
            for (int startCol = 0; startCol < n; startCol++)
            {
                //even no of col -> Top to bottom 
                if ((startCol & 1) == 0)
                {
                    for (int i = 0; i < m; i++)
                    {
                        Console.Write(_matrices[i, startCol] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    //odd no of col -> Bottom to Top
                    for (int i = m - 1; i >= 0; i--)
                    {
                        Console.Write(_matrices[i, startCol] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
