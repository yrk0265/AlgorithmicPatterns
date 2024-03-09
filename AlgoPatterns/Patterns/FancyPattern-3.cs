using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Patterns
{
    internal class FancyPattern_3
    {
        public void FancyPattern(int n)
        {
            Console.Write("* ");
            Console.WriteLine();
            for (int rows = 0; rows < n; rows++)
            {
                Console.Write("* ");
                for (int col = 0; col < rows + 1; col++)
                {
                    Console.Write(col + 1 + " ");
                }
                for (int col = 0; col < rows; col++)
                {
                    Console.Write(rows - col + " ");
                }
                Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}
