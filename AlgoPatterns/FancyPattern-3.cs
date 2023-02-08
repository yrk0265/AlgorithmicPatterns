using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject
{
    internal class FancyPattern_3
    {
        public void FancyPattern(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                //first half
                for (int col = 0; col < 2*n -(2*rows + 1); col++)
                {
                    if (col == 0 || col == (2 * n - (2 * rows)))
                        Console.Write("* ");
                    else
                        Console.Write(col+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
