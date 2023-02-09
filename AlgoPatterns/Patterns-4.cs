using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject
{
    internal class Patterns_4
    {
        public void Pattern(int n)
        {
            int i, j;
            for (j = 2 * n - 1; j >= 1 - 2 * n; j = j - 2)
            {
                for (i = 0; i < n; i++)  
                {
                    if (2 * i + Math.Abs(j) < 2 * n)
                        Console.Write((((n - Math.Abs(j / 2) - 1) * (n - Math.Abs(j / 2))) / 2) + i + 1+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
