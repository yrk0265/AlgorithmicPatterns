using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Arrays
{
    internal class YMediaLabsMatrices
    {
        private int[,] _matrices;
        public YMediaLabsMatrices(int[,] matrices)
        {
            _matrices = matrices;
        }
        public void Swap()
        {
            int m = _matrices.GetLength(0);
            int n = _matrices.GetLength(1);
            (_matrices[0, 0], _matrices[m - 1, n - 1]) = (_matrices[m - 1, n - 1], _matrices[0, 0]);
            (_matrices[0, n-1], _matrices[m-1,0]) = (_matrices[m - 1, 0], _matrices[0, n - 1]);
        }
    }
}
